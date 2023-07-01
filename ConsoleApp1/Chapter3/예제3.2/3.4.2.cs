/*3.4.2 가변 배열*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[][] arr = new int[5][];         // 2차원 가변 배열
			arr[0] = new int[10];
			arr[1] = new int[9];
			arr[2] = new int[8];
			arr[3] = new int[3];
			arr[4] = new int[5];
        }
	}
}