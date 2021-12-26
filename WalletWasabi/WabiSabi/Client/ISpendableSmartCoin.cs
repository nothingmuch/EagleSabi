using WalletWasabi.Blockchain.TransactionOutputs;

namespace WalletWasabi.WabiSabi.Client
{
	public interface ISpendableSmartCoin : ISpendableCoin, IMutableCoinJoinProperties
	{
		public int AnonymitySetSizeEstimate { get; }
	}
}
