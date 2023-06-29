/*값을 가져오려면 해당 필드의 타입과 동일한 타입으로 받을 수 있음.*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string author = gulliver.Author;
			decimal isbn13 = gulliver.ISBN13;
			string title = gulliver.Title;
			string contents = gulliver.Contents;
			int pageCount = gulliver.PageCount;
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