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

    static public implicit operator Won(Yen yen)
    {
        return new Won(yen.Money * 13m);    // 1엔당 13원으로 가정
    }
}

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Yen yen = new Yen(100);

            Won won1 = yen;         // 암시적(implicit) 형변환 가능
            Won won2 = (Won)yen;    // 명시적(explicit) 형변환 가능
        }
    }
}