/*필드에 값을 대입
객체.필드명 = 필드의_타입과_일치하는_표현식;
필드로부터 값을 가져옴
필드의_타입과_일치하는_변수 = 객체.필드명;*/

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