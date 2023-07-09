﻿/*4.4.2.2 연산자 오버로드*/

using System;

public class Kilogram
{
    double mass;

    public Kilogram(double value)
    {
        this.mass = value;
    }

    public Kilogram Add(Kilogram target)
    {
        return new Kilogram(this.mass + target.mass);
    }

    public override string ToString()
    {
        return mass + "kg";
    }
}


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 5;
            int n2 = 10;
            int sum = n1 + n2;  // sum 값은 15

            string txt1 = "123";
            string txt2 = "456";
            Console.WriteLine(txt1 + txt2); // 출력 결과 123456

            // Kilogram 타입 사용 예제
            Kilogram kg1 = new Kilogram(5);
            Kilogram kg2 = new Kilogram(10);

            Kilogram kg3 = kg1.Add(kg2);

            Console.WriteLine(kg3); // 출력 결과: 15kg
        }
    }
}