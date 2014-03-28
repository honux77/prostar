using System;

class Test {
	static void Main(string[] args) {
		Random r = new Random();
		int x = r.Next(1,11); //generate random number
		int a = 0;
		int count = 0;

		while(true) {
			Console.Write("guess number(1-10)? ");
			a = Convert.ToInt32(Console.ReadLine());
			count++;

			if(x ==a ) //if right?
				break;
			else if (x > a)
				Console.WriteLine("Too Small!");
			else
				Console.WriteLine("Too Big!");
		}

		//finally you're right!
		Console.WriteLine("{0} try! Thank you!!",count);
	}
}
