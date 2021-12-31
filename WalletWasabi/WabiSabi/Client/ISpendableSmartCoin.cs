using WalletWasabi.Blockchain.TransactionOutputs;

namespace WalletWasabi.WabiSabi.Client
{
	public interface ISpendableSmartCoin : ISpendableCoin, ICoinJoinEvents, IAbstractCoin
	{
		public int AnonymitySetSizeEstimate { get; }
		public bool IsConfirmed { get; }
		public bool IsBanned { get; }
	}
}
