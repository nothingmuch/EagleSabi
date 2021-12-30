using NBitcoin;
using System.Threading;
using System.Threading.Tasks;

namespace WalletWasabi.WabiSabi.Client
{
	public interface IAsyncCoinWithSignCapability : IAsyncCoin
	{
		Task<(uint, WitScript)> SignAsync(Transaction transaction, CancellationToken cancellationToken = default);
	}
}
