/*3.5.2.4 foreach 문*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < 5; i ++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}