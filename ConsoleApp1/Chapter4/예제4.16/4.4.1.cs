/*4.4.1 메서드 오버라이드*/

class Mammal
{
    public void Move()
    {
        Console.WriteLine("이동한다.");
    }
}

class Lion : Mammal
{
}

class Whale : Mammal
{
}

class Human : Mammal
{
}
