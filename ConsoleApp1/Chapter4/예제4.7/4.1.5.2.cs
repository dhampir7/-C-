/*4.1.5.2 정적 메서드 ) 정적 메서드(static method)는 일반 메서드에 static 예약어를 붙여서 정의한다.
정적 메서드 역시 new로 객체를 생성하는 것과 무관하게 사용할 수 있으므로 [클래스이름].[정적메서드] 형태로 호출할 수 있다.

/*4.1.5.2 정적 메서드*/

using System;

namespace ConsoleApp1
{
    class Person
    {
        static private int CountOfInstance; // private 정적 필드

        public Person(string name)
        {
            CountOfInstance++;
        }

        static public void OutputCount() // public 정적 메서드
        {
            Console.WriteLine(CountOfInstance); // 정적 메서드에서 정적 필드에 접근
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person.OutputCount();   // 클래스 이름으로 정적 메서드 호출

            Person person1 = new Person("홍길동");
            Person person2 = new Person("홍길순");

            Person.OutputCount();   // 출력 결과: 2
        }
    }
}
