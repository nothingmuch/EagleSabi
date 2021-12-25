@0xe2c5bc2f818c1ab9;

struct CommitmentData {
	data @0 :Data;
}

struct OwnershipProof {
	data @0 :Data;
}

interface SpendableCoin {
	coin @0 () -> (coin :import "bitcoin.capnp".Coin);
	createOwnershipProof @1 (commitmentData :CommitmentData) -> (ownershipProof :OwnershipProof);
	sign @2 (unsignedTransaction :Data) -> (witness :import "bitcoin.capnp".WitScript);
}

interface CoinJoinClient {
	startRound @0 (coins :List(SpendableCoin)) -> (tx :Data);
}
