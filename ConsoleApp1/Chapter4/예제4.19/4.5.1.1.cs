/*4.4.2.3 클래스 간의 형변환*/

using System;

public class Platter
{
}

public class Head
{
}

public class HardDisk
{
    Platter[] platter;
    Head head;
}

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            HardDisk.Head head = new HardDisk().Head();   // 접근 제한 컴파일 오류
        }
    }
}