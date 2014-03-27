using System;

class Test {
	static void Main(string[] args) {
		double x =  10 / 3;
		Console.WriteLine(x); //(1)
		x = 10.0 /3;
		Console.WriteLine(x); //(2)
		x = (double) 10 /3;
		Console.WriteLine(x);
		x = (double) (10 /3);
		Console.WriteLine(x);
	}
}
