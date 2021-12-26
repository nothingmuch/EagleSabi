namespace WalletWasabi.Blockchain.TransactionOutputs
{
	public interface IMutableCoinJoinProperties
	{
		bool CoinJoinInProgress { get; set; }
		bool SpentAccordingToBackend { get; set; }
		DateTimeOffset? BannedUntilUtc { get; set; }
		bool IsBanned { get; }

		[Obsolete("horrible interface")]
		void SetIsBanned();
	}
}
