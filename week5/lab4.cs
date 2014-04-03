using System;

namespace Next {
	public class Next {
		public static int[] ReadInts(string msg) {
			int[] arr;
			//fix and fill
			arr = new int[3] {1, 2, 3};

			return arr;
		}
	} //end of Next

	class Test {
		static void Main(string[] args) {
			int[] arr = Next.ReadInts("input test numbers");
			foreach (int i in arr)
				Console.WriteLine(i);
		}
	}
}
