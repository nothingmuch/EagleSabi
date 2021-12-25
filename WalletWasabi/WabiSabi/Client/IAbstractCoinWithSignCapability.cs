using NBitcoin;

namespace WalletWasabi.WabiSabi.Client
{
	public interface IAbstractCoinWithSignCapability : IAbstractCoin
	{
		void Sign(Transaction transaction);
	}
}
