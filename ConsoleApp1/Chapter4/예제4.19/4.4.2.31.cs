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
            Won won = new Won(1000);
            Dollar dollar = new Dollar(1);
            Yen yen = new Yen(13);

            won = yen;      // yen과 won의 타입이 다르기 때문에 컴파일 시에 오류 발생
        }
    }
}