using System;
class Test {
	static void Main(string[] args) {
		Console.WriteLine("How many?");
		int n;
		n = Convert.ToInt32(Console.ReadLine());
		int[] array;
		array = new int[n];
		int sum = 0;

		for (int s =0; s< array.Length; s++) {
			string words = Console.ReadLine();
			array[s] = Convert.ToInt32(words);
		}
		for (int s=0; s< array.Length; s++)
			sum += array[s];

		Console.WriteLine("Sum: {0}",sum );
		Console.WriteLine("Count: {0}",array.Length );
		Console.WriteLine("Avg: {0}",sum / array.Length);
	}
}
