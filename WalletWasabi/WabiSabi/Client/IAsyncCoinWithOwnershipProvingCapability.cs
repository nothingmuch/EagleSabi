using System.Threading;
using System.Threading.Tasks;
using WalletWasabi.Crypto;

namespace WalletWasabi.WabiSabi.Client
{
	public interface IAsyncCoinWithOwnershipProvingCapability : IAsyncCoin
	{
		Task<OwnershipProof> GenerateOwnershipProofAsync(CoinJoinInputCommitmentData commitmentData, CancellationToken cancellationToken = default);
	}
}
