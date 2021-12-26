using NBitcoin;
using System.Linq;
using System.Text;

namespace WalletWasabi.Crypto
{
	public record CoinJoinInputCommitmentData
	{
		private byte[] _coordinatorIdentifier;
		private byte[] _roundIdentifier;

		public CoinJoinInputCommitmentData(string coordinatorIdentifier, uint256 roundIdentifier)
			: this(Encoding.ASCII.GetBytes(coordinatorIdentifier), roundIdentifier.ToBytes())
		{
		}

		public CoinJoinInputCommitmentData(byte[] coordinatorIdentifier, byte[] roundIdentifier)
		{
			_coordinatorIdentifier = coordinatorIdentifier;
			_roundIdentifier = roundIdentifier;
		}

		public static CoinJoinInputCommitmentData FromBytes(byte[] bytes)
		{
			var i = BitConverter.ToInt32(bytes) + 4;
			return new CoinJoinInputCommitmentData(bytes[4..i], bytes[i..]);
		}

		public byte[] ToBytes() =>
			BitConverter.GetBytes(_coordinatorIdentifier.Length)
				.Concat(_coordinatorIdentifier)
				.Concat(_roundIdentifier)
				.ToArray();
	}
}
