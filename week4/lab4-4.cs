using System;

class test {

	//string split example
	static void Main(string[] args) {
		string line = Console.ReadLine();
		string[] words = line.Split(' ');
		int[] array = new int[words.Length];

		for (int i = 0; i < words.Length; i++)
			array[i] = Convert.ToInt32(words[i]);

		//bonus
		foreach (int a in array)
			Console.WriteLine(a);
	}
}
