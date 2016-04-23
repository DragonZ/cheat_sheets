public class Test {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		CallCenter ch = CallCenter.getInstance();

		Caller alice = new Caller(1, "Alice");
		Caller bob = new Caller(2, "Bob");
		ch.dispatchCall(alice);
		ch.dispatchCall(bob);
	}

}
