using NBitcoin;
using System.Threading;
using System.Threading.Tasks;

namespace WalletWasabi.WabiSabi.Client
{
	public interface IAsyncCoin
	{
		Task<Coin> GetCoinAsync(CancellationToken cancellationToken_ = default);
	}
}
