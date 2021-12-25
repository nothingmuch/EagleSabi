using NBitcoin;
using WalletWasabi.Blockchain.TransactionOutputs;
using WalletWasabi.Crypto;

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
		public Money Amount => SmartCoin.Amount;
		public Script ScriptPubKey => SmartCoin.ScriptPubKey;
		public OutPoint OutPoint => SmartCoin.Coin.Outpoint;

		[Obsolete("not sure which one to deprecate to be honest, but OutPoint vs Outpoint is inconsistent. follow Core?")]
		public OutPoint Outpoint => SmartCoin.Coin.Outpoint;

		public void Sign(Transaction transaction)
		{
			transaction.Sign(BitcoinSecret, SmartCoin.Coin);
		}

		public static implicit operator SpendableCoin(SpendableSmartCoin coin) => new(coin.SmartCoin.Coin, coin.BitcoinSecret);
	}
}
