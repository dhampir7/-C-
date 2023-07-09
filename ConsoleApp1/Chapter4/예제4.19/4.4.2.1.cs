﻿/*4.4.2.1 메서드 오버로드*/

using System;

class Mathematics
{

    public int AbsInt(int value)
    {
        return (value >= 0) ? value : -value;
    }

    public double AbsDouble(double value)
    {
        return (value >= 0) ? value : -value;
    }

    public decimal AbsDecimal(decimal value)
    {
        return (value >= 0) ? value : -value;
    }
}

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathematics math = new Mathematics();

            Console.WriteLine(math.AbsInt(-5)); // 출력 결과 5
            Console.WriteLine(math.AbsDouble(-10.052)); // 출력 결과 10.052
            Console.WriteLine(math.AbsDecimal(20.01m)); // 출력 결과 20.01
        }
    }
}