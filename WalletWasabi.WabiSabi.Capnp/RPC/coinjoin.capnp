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

# TODO front load coin data: struct SpendableCoin { coin :Coin; spendCapability interface { ... } }
interface SpendableCoin {
	coin @0 () -> (coin :Bitcoin.Coin);
	proveOwnership @1 (commitmentData :CommitmentData) -> (ownershipProof :OwnershipProof);
	sign @2 (unsignedTransaction :RawTransaction) -> (index :UInt32, witness :Bitcoin.WitScript);
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

# spend capability implies exclusive control, disposal = releasing the lock
# TODO front load coin data: struct SpendableSmartCoin { coin :Coin; status :CoinStatus; spendCapability interface { ... } }
interface SpendableSmartCoin extends(SpendableCoin, CoinJoinEvents) {
	getStatus @0 () -> (status :CoinStatus);
}

interface Wallet {
	coins @0 () -> (coins :List(SpendableSmartCoin));
	generateSelfSpendScripts @1 (count :Int32) -> (scriptPubKeys :List(Bitcoin.Script));
}

interface CoinJoiner {
	startCoinJoin @0 (wallet :Wallet) -> (succeeded :Bool); # TODO return tx or error
	inCriticalCoinJoinState @1 () -> (inCritical :Bool); # TODO replace with events
}
