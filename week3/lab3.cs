using System;
namespace next {
	public class Student {
		public String name;
		public int kor;
		public int math;
		public int avg;
	}

	class Test{
		static void Main(String[] args) {
			//for student s1
			Student s1 = new Student();
			//Student s2 = //implement
			s1.name = "Lim";
			s1.kor = 80;
			s1.math = 90;
			//wrong code, fix it
			s1.avg = 0;

			//for Student s2
			//s2. ... 

			//caculate avg of two student
			int tavg;
			//implement
			tavg = 0;
			
			Console.WriteLine("{0}의 평균은 {1} 입니다.", s1.name, s1.avg);
			//Console.WriteLine("{0}의 평균은 {1} 입니다.", s2.name, s2.avg);
			//Console.WriteLine("{0}과 {1}의 전체 평균은 {2} 입니다.", ... );

		}
	}
}

