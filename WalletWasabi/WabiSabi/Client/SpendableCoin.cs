using NBitcoin;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WalletWasabi.WabiSabi.Client
{
	public record SpendableCoin(Coin Coin, BitcoinSecret BitcoinSecret) : IAsyncCoinWithSignCapability
	{
		public Task<Coin> GetCoinAsync(CancellationToken _) => Task.FromResult(Coin);

		public (uint, WitScript) Sign(Transaction transaction)
		{
			var clone = transaction.Clone();
			var txInput = clone.Inputs.AsIndexedInputs().FirstOrDefault(input => input.PrevOut == Coin.Outpoint);

			if (txInput is null)
			{
				throw new InvalidOperationException($"Missing input.");
			}

			clone.Sign(BitcoinSecret, Coin);

			if (!txInput.VerifyScript(Coin.TxOut, out var error))
			{
				throw new InvalidOperationException($"Witness is missing. Reason {nameof(ScriptError)} code: {error}.");
			}

			return (txInput.Index, txInput.WitScript);
		}

		public Task<(uint, WitScript)> SignAsync(Transaction transaction, CancellationToken _ = default)
			=> Task.FromResult(Sign(transaction));
	}
}
