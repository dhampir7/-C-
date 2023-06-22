/*이스케이프 시퀀스 사용*/

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = '\t';    // TAB 문자를 표현
            char ch2 = 'T';
            char ch3 = '\n';    // 개행(NEW LINE) 문자를 표현
            char ch4 = 'o';

            Console.WriteLine(ch1);
            Console.WriteLine(ch2);
            Console.WriteLine(ch3);
            Console.WriteLine(ch4);
            Console.WriteLine(ch1);
            Console.WriteLine(ch4);
        }
    }
}