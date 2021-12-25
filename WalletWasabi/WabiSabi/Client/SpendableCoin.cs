using NBitcoin;

namespace WalletWasabi.WabiSabi.Client
{
	public record SpendableCoin(Coin Coin, BitcoinSecret BitcoinSecret) : IAbstractCoinWithSignCapability
	{
		// TODO provide minimal interfaces
		public Money Amount => Coin.Amount;
		public TxOut TxOut => Coin.TxOut;
		public Script ScriptPubKey => Coin.ScriptPubKey;
		public OutPoint OutPoint => Coin.Outpoint;

		[Obsolete("not sure which one to deprecate to be honest, but OutPoint vs Outpoint is inconsistent. follow Core?")]
		public OutPoint Outpoint => Coin.Outpoint;

		public void Sign(Transaction transaction)
		{
			transaction.Sign(BitcoinSecret, Coin);
		}
	}
}
