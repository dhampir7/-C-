/*C#에서는 case 문에 break를 포함하는 것이 강제 사항이라서 break가 없으면 컴파일할 때 오류가 발생.
대신 case 문에 실행해야 할 코드가 포함돼 있지 않다면 break를 생략하는 것도 가능*/

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "C#";

            switch (text)
            {
                case "C#":
                case "VB.NET":
                    Console.WriteLine(".NET 호환 언어");
                    break;

                case "Java":
                    Console.WriteLine("JVM 언어");
                    break;

                default:
                    Console.WriteLine("알 수 없음");
                    break;
            }
        }
    }
}