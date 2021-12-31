@0xe2c5bc2f818c1ab9;

using CSharp = import "csharp.capnp";
$CSharp.namespace("WalletWasabi.WabiSabi.Capnp.RPC.CoinJoin");

using Bitcoin = import "bitcoin.capnp";

struct CommitmentData {
	data @0 :Data;
}

struct OwnershipProof {
	data @0 :Data;
}

struct RawTransaction {
	data @0 :Data;
}

interface SpendCapability {
	proveOwnership @0 (commitmentData :CommitmentData) -> (ownershipProof :OwnershipProof);
	sign @1 (unsignedTransaction :RawTransaction) -> (index :UInt32, witness :Bitcoin.WitScript); # TODO error? SignableTransaction?
}

struct DateTimeOffset {
	unixMilliseconds @0 :Int64;
}

interface CoinJoinEvents {
	coinJoinStarted @0 () -> ();
	coinJoinNoLongerInProgress @1 () -> ();
	reportedSpentAccordingToBackend @2 () -> ();
	banned @3 (until :DateTimeOffset) -> ();
}

struct CoinStatus {
	isConfirmed @0 :Bool;
	isBanned @1 :Bool;
	anonymitySetSizeEstimate @2 :Int32;
}

# spend capability implies exclusive control, release by disposing
struct SpendableCoin {
	coin @0 :Bitcoin.Coin;
	spendCapability @1 :SpendCapability;
	status @2 :CoinStatus; # TODO
	events @3 :CoinJoinEvents;
}

interface Wallet {
	getAvailableCoins @0 () -> (coins :List(SpendableCoin));
	generateSelfSpendScripts @1 (count :Int32) -> (scriptPubKeys :List(Bitcoin.Script));
}

interface CoinJoiner {
	startCoinJoin @0 (wallet :Wallet) -> (succeeded :Bool); # TODO return tx or error
}
