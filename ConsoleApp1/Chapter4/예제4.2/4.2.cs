/*"class Book"뿐 아니라 이제 "class Program" 정의도 눈에 들어올 것임.
C# 프로그램은 이처럼 모든 것이 타입으로 정의돼 있다는 특징이 있음.*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Book gulliver = new Book();
		}

		class Book
		{
			string Title;
			decimal ISBN13;
			string Contents;
			string Author;
			int PageCount;
		}
    }
}