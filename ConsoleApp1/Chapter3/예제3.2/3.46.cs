/*3.4 배열*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] students = new int[60];
			students[0] = 50;
			Console.WriteLine(students[0]); // 출력 결과: 50

			students = new int[120];
			Console.WriteLine(students[0]);	// 출력 결과: 0
        }
	}
}