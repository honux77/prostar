using System;
public class NumPuzzle {
	private int[,] mData;
	private int mSize;
	public void init(int size) {
	}
	public string findMove() {
		string ret="";
		return ret;
	}
}

public class Test{
	public static void Main(string[] args) {
		NumPuzzle np = new NumPuzzle();
		//initialize
		np.init(3); // 3 * 3 1 2 3 4 5 6 7 8 0
		//np.shuffle();

		//findMoveTest
		string move = np.findMove(); //6 8
		if (move != "6,8") {
			Console.WriteLine("findMove Test Fail!");
			Environment.Exit(1);
		}
		Console.WriteLine("Test1 passed");
	}
}
