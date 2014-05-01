using System;
using System.Threading;

class Timer {
	public static void Print(int sec) {
		int i = 0;
		while (i < sec) {
			Console.WriteLine(++i);
			Thread.Sleep(500); //ms
		}
	}
	static void Main() {
		Timer.Print(10);
		Console.WriteLine("Bye~"); 
}

