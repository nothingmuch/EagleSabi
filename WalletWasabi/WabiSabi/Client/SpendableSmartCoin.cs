using NBitcoin;
using System.Linq;
using WalletWasabi.Blockchain.Keys;
using WalletWasabi.Blockchain.TransactionOutputs;
using WalletWasabi.Crypto;
using WalletWasabi.Wallets;

namespace WalletWasabi.WabiSabi.Client
{
	// There's no interface shared by Coin and SmartCoin, so as a temporary fix
	// just have two separate variants that don't both inhabit a polymorphic
	// type, because CJC needs smartcoin functionality, but ArenaClient tests
	// use Coin not SmartCoin, but unification is the goal of this refactor. An
	// implicit conversion is provided as a syntactic bridge.
	public record SpendableSmartCoin(SmartCoin SmartCoin, BitcoinSecret BitcoinSecret, Key IdentificationKey)
	{
		public OwnershipProof GenerateOwnershipProof(CoinJoinInputCommitmentData commitmentData)
		=> OwnershipProof.GenerateCoinJoinInputProof(
					BitcoinSecret.PrivateKey,
					new OwnershipIdentifier(IdentificationKey, BitcoinSecret.PrivateKey.PubKey.WitHash.ScriptPubKey),
					commitmentData);

		// TODO provide minimal interfaces
		public TxOut TxOut => SmartCoin.TxOut;
		public uint Index => SmartCoin.Index;
		public Money Amount => SmartCoin.Amount;
		public uint256 TransactionId => SmartCoin.TransactionId;
		public Script ScriptPubKey => SmartCoin.ScriptPubKey;
		public HdPubKey HdPubKey => SmartCoin.HdPubKey;
		public OutPoint OutPoint => SmartCoin.Coin.Outpoint;

		[Obsolete("not sure which one to deprecate to be honest, but OutPoint vs Outpoint is inconsistent. follow Core?")]
		public OutPoint Outpoint => SmartCoin.Coin.Outpoint;

		public void Sign(Transaction transaction)
		{
			transaction.Sign(BitcoinSecret, SmartCoin.Coin);
		}

		public static implicit operator SpendableCoin(SpendableSmartCoin coin) => new(coin.SmartCoin.Coin, coin.BitcoinSecret);

		public static SpendableSmartCoin Create(SmartCoin coin, Wallet wallet)
			=> Create(coin, wallet.KeyManager, wallet.Kitchen);

		[Obsolete("garbage tests")]
		public static SpendableSmartCoin Create(SmartCoin coin, KeyManager keymanager)
		{
			var kitchen = new Kitchen();
			kitchen.Cook("");
			return Create(coin, keymanager, kitchen);
		}

		public static SpendableSmartCoin Create(SmartCoin coin, KeyManager keymanager, Kitchen kitchen)
		{
			var hdKey = keymanager.GetSecrets(kitchen.SaltSoup(), coin.ScriptPubKey).Single();
			var secret = hdKey.PrivateKey.GetBitcoinSecret(keymanager.GetNetwork());
			if (hdKey.PrivateKey.PubKey.WitHash.ScriptPubKey != coin.ScriptPubKey)
			{
				throw new InvalidOperationException("The key cannot generate the utxo scriptpubkey. This could happen if the wallet password is not the correct one.");
			}

			var masterKey = keymanager.GetMasterExtKey(kitchen.SaltSoup()).PrivateKey;
			var identificationMasterKey = Slip21Node.FromSeed(masterKey.ToBytes());
			var identificationKey = identificationMasterKey.DeriveChild("SLIP-0019").DeriveChild("Ownership identification key").Key;

			return new SpendableSmartCoin(coin, secret, identificationKey);
		}
	}
}
