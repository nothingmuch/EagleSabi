@0xc7ccb605fc198a84;

struct Money {
	satoshis @0 :UInt64;
}

struct Script {
	data @0 :Data;
}

struct WitScript {
	pushes @0 :List(Data);
}

struct TxOut {
	scriptPubKey @0 :Script;
	value @1 :Money;
}

struct UInt256 {
	x0 @0 :UInt64;
	x1 @1 :UInt64;
	x2 @2 :UInt64;
	x3 @3 :UInt64;
}

struct OutPoint {
	txid @0 :UInt256;
	nout @1 :UInt32;
}

struct Coin {
	outpoint @0 :OutPoint;
	txout @1 :TxOut;
}

