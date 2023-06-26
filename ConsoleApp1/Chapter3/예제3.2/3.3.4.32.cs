/*참조형 변수가 더는 사용되지 않음을 명시하기 위해 null을 할당*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
            string name = "C#";
            name = null;
        }
	}
}