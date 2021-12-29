using System.Threading;
using System.Threading.Tasks;

namespace WalletWasabi.Blockchain.TransactionOutputs
{
	public interface IMutableCoinJoinProperties : ICoinJoinEvents
	{
		bool CoinJoinInProgress { get; set; }
		bool SpentAccordingToBackend { get; set; }
		DateTimeOffset? BannedUntilUtc { get; set; }
		bool IsBanned { get; }

		[Obsolete("horrible interface")]
		void SetIsBanned();

		void CoinJoinStarted()
		{
			CoinJoinInProgress = true;
		}

		void CoinJoinNoLongerInProgress()
		{
			CoinJoinInProgress = false;
		}

		void ReportedSpentAccordingToBackend()
		{
			SpentAccordingToBackend = true;
		}

		void Banned(DateTimeOffset bannedUntilUtc)
		{
			BannedUntilUtc = BannedUntilUtc; // last writer wins yolo consistency model
			SetIsBanned(); // refresh
		}

		async Task ICoinJoinEvents.CoinJoinStartedAsync(CancellationToken cancellationToken_ = default) => await Task.Run(() => CoinJoinStarted(), cancellationToken_).ConfigureAwait(false);

		async Task ICoinJoinEvents.CoinJoinNoLongerInProgressAsync(CancellationToken cancellationToken_ = default) => await Task.Run(() => CoinJoinNoLongerInProgress(), cancellationToken_).ConfigureAwait(false);

		async Task ICoinJoinEvents.ReportedSpentAccordingToBackendAsync(CancellationToken cancellationToken_ = default) => await Task.Run(() => ReportedSpentAccordingToBackend(), cancellationToken_).ConfigureAwait(false);

		async Task ICoinJoinEvents.BannedAsync(DateTimeOffset bannedUntilUtc, CancellationToken cancellationToken_ = default) => await Task.Run(() => Banned(bannedUntilUtc), cancellationToken_).ConfigureAwait(false);
	}

	public interface ICoinJoinEvents : IDisposable
	{
		Task CoinJoinStartedAsync(CancellationToken cancellationToken_ = default);

		Task CoinJoinNoLongerInProgressAsync(CancellationToken cancellationToken_ = default);

		Task ReportedSpentAccordingToBackendAsync(CancellationToken cancellationToken_ = default);

		Task BannedAsync(DateTimeOffset until, CancellationToken cancellationToken_ = default);
	}
}
