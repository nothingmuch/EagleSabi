using WalletWasabi.Crypto;

namespace WalletWasabi.WabiSabi.Client
{
	public interface IAbstractCoinWithOwnershipProvingCapability : IAbstractCoin
	{
		OwnershipProof GenerateOwnershipProof(CoinJoinInputCommitmentData commitmentData);
	}
}
