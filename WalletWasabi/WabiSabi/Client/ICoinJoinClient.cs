using NBitcoin;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace WalletWasabi.WabiSabi.Client
{
	public interface ICoinJoinClient
	{
		Task<bool> StartCoinJoinAsync(IEnumerable<ISpendableSmartCoin> coins, Func<int, CancellationToken, Task<IEnumerable<Script>>> getSelfSpendDestinations, CancellationToken cancellationToken);

		public Task<bool> StartCoinJoinAsync(IEnumerable<ISpendableSmartCoin> coins, Func<int, IEnumerable<Script>> getSelfSpendDestinations, CancellationToken cancellationToken = default)
		{
			Task<IEnumerable<Script>> GetAsync(int i, CancellationToken _) => Task.FromResult(getSelfSpendDestinations(i));
			return StartCoinJoinAsync(coins, GetAsync, cancellationToken);
		}
	}
}
