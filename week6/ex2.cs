using System;
class Test {
	static void Main() {
		int[] x = {1,2,3};
		printIntArray(x);
		doubleArray(x);
		printIntArray(x);
	}

	static void printIntArray(int []arr) {
		foreach(int i in arr)
			Console.Write("{0}  ", i);
		Console.WriteLine("");
	}

	static void doubleArray(int[] n) {
		for (int i = 0; i < n.Length; i++)
			n[i] *=2;
	}
}

