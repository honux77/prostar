using System;
using System.Linq;
class Test {
	public static void Main() {
		int []a = {1,2};
		int [] b = {3};
		a= a.Concat(b).ToArray();
		foreach (int x in a)
			Console.WriteLine(x);
	}
}

