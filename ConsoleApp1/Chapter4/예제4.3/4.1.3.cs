/*C# 클래스에는 특별한 용도의 메서드가 있다. 이번 절에서는 그중 하나인 생성자(constructor)를 알아볼 텐데,
클래스에 생성자 메서드를 추가하면 객체가 "생성"되는 시점에 해당 메서드가 자동으로 호출된다. 
이런 점에서 생성자는 다른 여타 메서드와 구별되는 특징이 있다*/

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("person 객체 생성되기 전.");
            Person person = new Person();
            Console.WriteLine("person 객체 생성된 후.");
        }
    }

    class Person
    {
        string name;

        public Person()
        {
            name = "홍길동";
            Console.WriteLine("생성자 호출");
        }
    }

}