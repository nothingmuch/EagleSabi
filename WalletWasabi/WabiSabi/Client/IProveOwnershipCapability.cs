using System.Threading;
using System.Threading.Tasks;
using WalletWasabi.Crypto;

namespace WalletWasabi.WabiSabi.Client
{
	public interface IProveOwnershipCapability : IWithCoin
	{
		Task<OwnershipProof> GenerateOwnershipProofAsync(CoinJoinInputCommitmentData commitmentData, CancellationToken cancellationToken = default);
	}
}
