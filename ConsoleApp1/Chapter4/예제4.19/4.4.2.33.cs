/*4.4.2.3 클래스 간의 형변환*/

using System;

public class Currency
{
    decimal money;
    public decimal Money { get { return money; } }

    public Currency(decimal money)
    {
        this.money = money;
    }
}

public class Won : Currency
{
    public Won(decimal money) : base(money) { }
    public override string ToString()
    {
        return Money + "Won";
    }
}

public class Dollar : Currency
{
    public Dollar(decimal money) : base(money) { }

    public override string ToString()
    {
        return Money + "Dollar";
    }

    static public explicit operator Won(Dollar dollar)
    {
        return new Won(dollar.Money * 1000m);
    }
}

public class Yen : Currency
{
    public Yen(decimal money) : base(money) { }

    public override string ToString()
    {
        return Money + "Yen";
    }
}

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dollar dollar = new Dollar(1);

            Won won1 = dollar;          // 암시적(implicit) 형변환 불가능(컴파일 오류 발생)
            Won won2 = (Won)dollar;     // 명시적(explicit) 형변환 가능

            Console.WriteLine(won2);    // 출력 결과: 1000Won
        }
    }
}