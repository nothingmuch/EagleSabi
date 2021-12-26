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

interface SpendableCoin {
	coin @0 () -> (coin :Bitcoin.Coin);
	proveOwnership @1 (commitmentData :CommitmentData) -> (ownershipProof :OwnershipProof);
	sign @2 (unsignedTransaction :RawTransaction) -> (index :UInt32, witness :Bitcoin.WitScript);
}

struct DateTimeOffset {
	unixMilliseconds @0 :Int64;
}

interface IntProperty {
	getValue @0 () -> (value :Int32);
}

interface BoolProperty {
	getValue @0 () -> (value :Bool);
}

interface MutableBool extends(BoolProperty) {
	setValue @0 (value :Bool) -> ();
}

struct Option(T) {
	union {
		none @0 :Void;
		some @1 :T;
	}
}

interface Property(T) {
	getValue @0 () -> (value :T);
}

interface Mutable(T) extends(Property(T)) {
	setValue @0 (value :T) -> ();
}


interface HorribleIsBannedProperty extends(BoolProperty) {
	refresh @0 () -> ();
}

# TODO clean up
struct CoinState {
	anonymitySetSizeEstimate @0 :IntProperty;
	coinJoinInProgress @1 :MutableBool;
	spentAccordingToBackend @2 :MutableBool;
	bannedUntilUtc @3 :Mutable(Option(DateTimeOffset));
	isBanned @4 :HorribleIsBannedProperty;
	isConfirmed @5 :BoolProperty;
}

interface SpendableSmartCoin extends(SpendableCoin) {
	state @0 () -> (state :CoinState);
}

interface Wallet {
	coins @0 () -> (coins :List(SpendableSmartCoin));
	generateSelfSpendScripts @1 (count :Int32) -> (scriptPubKeys :List(Bitcoin.Script));
}

interface CoinJoinClient {
	startCoinJoin @0 (wallet :Wallet) -> (succeeded :Bool); # TODO return tx or error
	inCriticalCoinJoinState @1 () -> (inCritical :Bool); # TODO replace with events
}
