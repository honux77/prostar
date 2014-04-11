using System;
using Next;
class NumPrint{
	static void Main(string[] args) {
		int x = Input.ReadInt();
		int y = Input.ReadInt();
		for(int i = 0; i < x; i++) {
			for(int j = 0; j < y; j++)
				Console.Write("{0}{1} ",i,j);
			Console.Write("\n");
		}
	}
}

