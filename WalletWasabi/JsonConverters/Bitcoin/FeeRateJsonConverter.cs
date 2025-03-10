using NBitcoin;
using Newtonsoft.Json;

namespace WalletWasabi.JsonConverters.Bitcoin
{
	public class FeeRateJsonConverter : JsonConverter<FeeRate>
	{
		/// <inheritdoc />
		public override FeeRate? ReadJson(JsonReader reader, Type objectType, FeeRate? existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			var serialized = (long?)reader.Value;
			return serialized is null ? null : new FeeRate(Money.Satoshis(serialized.Value));
		}

		/// <inheritdoc />
		public override void WriteJson(JsonWriter writer, FeeRate? value, JsonSerializer serializer)
		{
			if (value is null)
			{
				writer.WriteNull();
			}
			else
			{
				writer.WriteValue(value.FeePerK.Satoshi);
			}
		}
	}
}
