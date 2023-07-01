/*3.5.3.1 continue 문*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int sum = 0;
			int n = 1;
			while (n ++ <= 1000)
			{
				if ((n % 3) == 0)
				{
					if ((n % 5) == 0)
					{
						sum += n;
					}
				}
			}
		}
    }
}