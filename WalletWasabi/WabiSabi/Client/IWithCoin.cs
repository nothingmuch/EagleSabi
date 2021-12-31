using NBitcoin;

namespace WalletWasabi.WabiSabi.Client
{
	public interface IWithCoin : IAbstractCoin
	{
		Coin Coin { get; }
		TxOut IAbstractCoin.TxOut => Coin.TxOut;
		OutPoint IAbstractCoin.Outpoint => Coin.Outpoint;
	}
}
