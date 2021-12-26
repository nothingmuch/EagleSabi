using NBitcoin;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WalletWasabi.Crypto;

namespace WalletWasabi.WabiSabi.Client
{
	public record SpendableCoin(Coin Coin, BitcoinSecret BitcoinSecret) : IAbstractCoinWithSignCapability
	{
		// TODO provide minimal interfaces
		public Money Amount => Coin.Amount;
		public TxOut TxOut => Coin.TxOut;
		public Script ScriptPubKey => Coin.ScriptPubKey;
		[Obsolete("not sure which one to deprecate to be honest, but OutPoint vs Outpoint is inconsistent. follow Core?")]
		public OutPoint OutPoint => Coin.Outpoint;

		public OutPoint Outpoint => Coin.Outpoint;

		public (uint, WitScript) Sign(Transaction transaction)
		{
			var clone = transaction.Clone();
			var txInput = clone.Inputs.AsIndexedInputs().FirstOrDefault(input => input.PrevOut == Outpoint);

			if (txInput is null)
			{
				throw new InvalidOperationException($"Missing input.");
			}

			clone.Sign(BitcoinSecret, Coin);

			if (!txInput.VerifyScript(TxOut, out var error))
			{
				throw new InvalidOperationException($"Witness is missing. Reason {nameof(ScriptError)} code: {error}.");
			}

			return (txInput.Index, txInput.WitScript);
		}

		public Task<(uint, WitScript)> SignAsync(Transaction transaction, CancellationToken _ = default)
			=> Task.FromResult(Sign(transaction));
	}
}
