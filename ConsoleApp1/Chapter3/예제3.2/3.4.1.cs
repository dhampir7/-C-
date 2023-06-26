/*3.4.1 다차원 배열 ) 차수가 2 이상이 되면 다차원 배열(multi-dimensional array)이라고 함. 
 *다차원 배열을 선언할 경우 차원 분리자인 콤마(',')를 이용해 선언하기만 하면 된다.*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] arr2 = new int[10, 5];       // 2차원 배열
			short[,,] arr3 = new short[8, 3, 10];	// 3차원 배열
        }
	}
}