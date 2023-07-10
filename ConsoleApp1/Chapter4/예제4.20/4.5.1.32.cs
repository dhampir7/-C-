/*4.5.1.3 델리게이트*/

using System;

namespace ConsoleApp1
{
    class Program
    {
        delegate void CalcDelegate(int x, int y);

        static void Add(int x, int y) { Console.WriteLine(x + y); }
        static void Subtract(int x, int y) { Console.WriteLine(x - y); }
        static void Multiply(int x, int y) { Console.WriteLine(x * y); }
        static void Divide(int x, int y) { Console.WriteLine(x / y); }

        static void Main(string[] args)
        {
            CalcDelegate calc = new CalcDelegate(Add);
            CalcDelegate subtractCalc = new CalcDelegate(Subtract);
            CalcDelegate multiplyCalc = new CalcDelegate(Multiply);
            CalcDelegate divideCalc = new CalcDelegate(Divide);

            calc = CalcDelegate.Combine(calc, subtractCalc) as CalcDelegate;
            calc = CalcDelegate.Combine(calc, multiplyCalc) as CalcDelegate;
            calc = CalcDelegate.Combine(calc, divideCalc) as CalcDelegate;

            calc(10, 5);
        }
    }
}