using System;
class MatSum {

	static void Main(string[] args) {
		int[,] x1, x2, sum;
		Console.Write("Input Array Size? ");
		int n = ReadInt();
		x1 = new int[n,n];
		x2 = new int[n,n];
		sum = new int[n,n];

		Console.WriteLine("Input array 1 ({0} * {1})",n, n);
		for(int i = 0; i < n; i++) 
			for(int j = 0; j < n; j++) {
				Console.Write("{0}{1}? ", i,j);
				x1[i,j] = ReadInt();
			}
		
		Console.WriteLine("Input array 2 ({0} * {1})",n, n);
		for(int i = 0; i < n; i++) 
			for(int j = 0; j < n; j++) {
				Console.Write("{0}{1}? ", i,j);
				x2[i,j] = ReadInt();
			}

		for (int i = 0; i < n; i++) {
			for(int j = 0; j < n; j++) {
				sum[i,j] = x1[i,j] + x2[i,j]; 
			}
		}
		PrintArray(x1, n);
		PrintArray(x2, n);
		PrintArray(sum, n);
	}

	static int ReadInt() {
		return Convert.ToInt32(Console.ReadLine());
	}
	static void PrintArray(int[,] a, int n) {
		for(int i =0; i < n; i++) {
			Console.Write("| ");
			for (int j = 0; j < n; j++)
				Console.Write(a[i,j] +" ");
			Console.WriteLine("|");
		}
		Console.WriteLine("");
	}
}
