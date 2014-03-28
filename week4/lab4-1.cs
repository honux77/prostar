using System;

class Test {
	static void Main(string[] args) {
		int n = 0;
		int sum =0;
		int count = 0;

		while(n!= -1) {		
		 sum = sum + n;
		 n = Convert.ToInt32(Console.ReadLine());
		 count++;
		}

		Console.WriteLine("{0} {1}", sum, (double)sum/(count-1));

	}
}
