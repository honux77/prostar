using System;
class test {
	static void Main(string[] args) {
		int x = Convert.ToInt32(Console.ReadLine());
		for(int i = 0; i < x; i++) {
			for(int j = 0; j < x - i; j++)
				Console.Write(" ");
			for(int j = 0; j < 2 * i + 1; j++) 
				Console.Write("*");
			Console.Write("\n");

		}
	}
}
