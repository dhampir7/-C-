/*3.5.1.3 switch 문*/

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