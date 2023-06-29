/*C#에서도 타입만 일치한다면 어떤 표현식이든 메서드의 인자로 전달할 수 있다.
이제 메서드까지 배웠으니, 다시 Book 클래스의 정의로 되돌아가 최종적으로 속성과 행위를 각각 필드와 메서드로 다음과 같이 표현할 수 있다*/

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