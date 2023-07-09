﻿/*4.4.1 메서드 오버라이드*/

using System;

class Mammal
{
    public void Move()
    {
        Console.WriteLine("이동한다.");
    }
}

class Lion : Mammal
{
    public void Move()
    {
        Console.WriteLine("네 발로 움직인다.");
    }
}

class Whale : Mammal
{
    public void Move()
    {
        Console.WriteLine("수영한다.");
    }
}

class Human : Mammal
{
    public void Move()
    {
        Console.WriteLine("두 발로 움직인다.");
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion();
            Mammal one = lion;  // 부모 타입으로 형변환

            one.Move();
        }
    }