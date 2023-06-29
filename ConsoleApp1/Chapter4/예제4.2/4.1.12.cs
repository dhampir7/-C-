/*그런데 현재 위와 같이 실습을 해 보면 C# 컴파일러가 오류를 발생시킬 것임.
왜냐하면 기본적으로 객체(예: class Book)의 필드는 외부(예: class Program)에서 접근할 수 없음.
만약 접근하고 싶다면 명시적으로 public이라는 예약어를 사용해 클래스의 필드를 다음과 같이 정의해야 함.*/

using System;

namespace ConsoleApp1
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
		public string Title;
		public decimal ISBN13;
		public string Contents;
		public string Author;
		public int PageCount;
    }
}