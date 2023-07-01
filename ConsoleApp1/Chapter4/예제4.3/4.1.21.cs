/*4.1.2 메서드*/

using System;

namespace ConsoleApp1
{
    class Book
    {
        public string Title;
        public decimal ISBN13;
        public string Contents;
        public string Author;
        public int PageCount;

        public void Open()
        {
            Console.WriteLine("Book is opened");
        }

        public void Close()
        {
            Console.WriteLine("Book is closed");
        }
    }
}