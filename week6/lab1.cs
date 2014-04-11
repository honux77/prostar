using System;

class Lab1 {
	static void Main() {
		string answer;
		answer = date(1,2);
		Console.WriteLine(answer);
		//Console.WriteLine(date(1, 2));
		Console.WriteLine(date(2, 1));
		Console.WriteLine(date(5, 5));
		Console.WriteLine(date(12, 31));

	}
	static string date(int month, int day) {
		int[] monthday = new int[12] {31,28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
		string[] weekday = new string[7] {"SUN","MON","TUE","WED","THR","FRI","SAT"};
		int date = day;

		for (int i = 0; i < month - 1; i++)
			date += monthday[i];

		return weekday[date % 7];
	}
}
