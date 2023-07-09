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
            decimal won = 30000;
            decimal dollar = won * 1200;
            decimal yen = won * 13;

            yen = dollar;   // 실수로 이렇게 대입해도 컴파일 오류가 발생하지 않는다.
        }
    }
}