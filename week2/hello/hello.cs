using System;

namespace Hoyoung {
	class HelloNext {
		static void Main(String[] args) {
			Console.WriteLine("Hello, Next");
			if(args.Length !=0)
				Print(args);
			else
				Console.WriteLine("Usage> " +AppDomain.CurrentDomain.FriendlyName + " NAME");

		}

		static void Print(String[] hi) {
		Console.Write("Hello, ");
		for (int i = 0; i < hi.Length; i++)
			Console.Write(hi[i] +" ");
		Console.Write("\n");
		}
	}
}
