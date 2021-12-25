using WalletWasabi.Blockchain.Keys;
using WalletWasabi.Blockchain.TransactionOutputs;

namespace WalletWasabi.WabiSabi.Client
{
	public interface ISpendableSmartCoin : ISpendableCoin, IMutableCoinJoinProperties
	{
		public HdPubKey HdPubKey { get; }
	}
}
