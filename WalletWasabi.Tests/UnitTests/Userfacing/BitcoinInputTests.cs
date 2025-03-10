using WalletWasabi.Helpers;
using Xunit;

namespace WalletWasabi.Tests.UnitTests
{
	public class BitcoinInputTests
	{
		[Theory]
		[InlineData("1", false, null)]
		[InlineData("1.", false, null)]
		[InlineData("1.0", false, null)]
		[InlineData("", false, null)]
		[InlineData("0.0", false, null)]
		[InlineData("0", false, null)]
		[InlineData("0.", false, null)]
		[InlineData(".1", false, null)]
		[InlineData(".", false, null)]
		[InlineData(",", true, ".")]
		[InlineData("20999999", false, null)]
		[InlineData("2.1", false, null)]
		[InlineData("1.11111111", false, null)]
		[InlineData("1.00000001", false, null)]
		[InlineData("20999999.9769", false, null)]
		[InlineData(" ", true, "")]
		[InlineData("  ", true, "")]
		[InlineData("abc", true, "")]
		[InlineData("1a", true, "1")]
		[InlineData("a1a", true, "1")]
		[InlineData("a1 a", true, "1")]
		[InlineData("a2 1 a", true, "21")]
		[InlineData("2,1", true, "2.1")]
		[InlineData("2٫1", true, "2.1")]
		[InlineData("2٬1", true, "2.1")]
		[InlineData("2⎖1", true, "2.1")]
		[InlineData("2·1", true, "2.1")]
		[InlineData("2'1", true, "2.1")]
		[InlineData("2.1.", true, "2.1")]
		[InlineData("2.1..", true, "2.1")]
		[InlineData("2.1.,.", true, "2.1")]
		[InlineData("2.1. . .", true, "2.1")]
		[InlineData("2.1.1", true, "")]
		[InlineData("2,1.1", true, "")]
		[InlineData(".1.", true, ".1")]
		[InlineData(",1", true, ".1")]
		[InlineData("..1", true, ".1")]
		[InlineData(".,1", true, ".1")]
		[InlineData("1.000000000", true, "1.00000000")]
		[InlineData("1.111111119", true, "1.11111111")]
		[InlineData("01", true, "1")]
		[InlineData("001", true, "1")]
		[InlineData("001.0", true, "1.0")]
		[InlineData("001.00", true, "1.00")]
		[InlineData("00", true, "0")]
		[InlineData("0  0", true, "0")]
		[InlineData("001.", true, "1.")]
		[InlineData("20999999.97690001", true, "20999999.9769")]
		[InlineData("30999999", true, "20999999.9769")]
		[InlineData("303333333333333333999999", true, "20999999.9769")]
		[InlineData("20999999.977", true, "20999999.9769")]
		[InlineData("209999990.9769", true, "20999999.9769")]
		[InlineData("20999999.976910000000000", true, "20999999.9769")]
		[InlineData("209999990000000000.97000000000069", true, "20999999.9769")]
		[InlineData("1.000000001", true, "1.00000000")]
		[InlineData("20999999.97000000000069", true, "20999999.97000000")]
		[InlineData("00....1...,a", true, "")]
		[InlineData("0...1.", true, "")]
		[InlineData("1...1.", true, "")]
		[InlineData("1.s.1...1.", true, "")]
		public void CorrectAmountText(string amount, bool expectedResult, string expectedCorrection)
		{
			var result = BitcoinInput.TryCorrectAmount(amount, out var correction);
			Assert.Equal(expectedCorrection, correction);
			Assert.Equal(expectedResult, result);
		}
	}
}
