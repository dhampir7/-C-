/*4.1.1 필드*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Book gulliver = new Book();

			gulliver.Author = "Jonathan Swift";
			gulliver.ISBN13 = 9788983920775m;
			gulliver.Title = "걸리버 여행기";
			gulliver.Contents = "...";
			gulliver.PageCount = 384;
		}
    }
}