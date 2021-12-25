using NBitcoin;

namespace WalletWasabi.WabiSabi.Models
{
	public record MoneyRange(Money Min, Money Max)
	{
		public bool Contains(Money value) =>
			Min <= value && value <= Max;
		public bool Contains(IMoney value) =>
			Min.CompareTo(value) <= 0 && value.CompareTo(Max) <= 0;
	}
}
