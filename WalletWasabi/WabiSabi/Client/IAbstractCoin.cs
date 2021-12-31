using NBitcoin;

namespace WalletWasabi.WabiSabi.Client
{
	// NBitcoin's ICoin is for abstracting colored coin functionality, this
	// ICoin is only for BTC, and added for polymorphism reasons.
	public interface IAbstractCoin
	{
		TxOut TxOut { get; }
		OutPoint Outpoint { get; }

		Script ScriptPubKey => TxOut.ScriptPubKey;
		Money Amount => TxOut.Value;

		Money EffectiveValue(FeeRate feeRate) => Amount - feeRate.GetFee(ScriptPubKey.EstimateInputVsize());
	}
}
