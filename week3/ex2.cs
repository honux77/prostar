using System;
namespace next {
	class HelloNext {
		static void Main(String[] args) {
			String m1;
			int x, y, z;
			//input first number
			Console.WriteLine("Type first number:");
			m1 = Console.ReadLine();
			x = Convert.ToInt32(m1);

			//input second number
			Console.WriteLine("Type second number:");
			m1 = Console.ReadLine();
			y = Convert.ToInt32(m1);

			//z = x + y
			z = x + y;

			//print result
			Console.WriteLine("{0} + {1}  = {2}", x, y, z);

		}
	}
}

