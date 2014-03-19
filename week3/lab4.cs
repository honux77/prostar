using System;
namespace next {

	public class Circle {
		public int x;
		public int y;
		//Is it enough to draw circle?
	}

	class CircleTest{
		static void Main(String[] args) {
			Circle c1, c2;
			String tempstr;

			//initialize c1 & c2
			//implement

			Console.WriteLine("원충돌 테스트");
			Console.Write("circle1 X? ");
			tempstr = Console.ReadLine();
			c1.x = Convert.ToInt32(tempstr);
			// implement ...

			//fix code
			if(true)
				Console.WriteLine("두 원은 충돌합니다.");
			else
				Console.WriteLine("두 원은 충돌하지 않습니다.");
			
		}
	}
}

