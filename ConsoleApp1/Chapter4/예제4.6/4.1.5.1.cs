/*4.1.5.1 정적 필드*/

class Person
{
    static public int CountOfInstance;  // static 예약어로 정적 필드로 만듦
    public string _name;                // 인스턴스 필드

    public Person(string name)
    {
        CountOfInstance++;
        _name = name;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Person.CountOfInstance);  // 출력 결과: 0

        Person person1 = new Person("홍길동");
        Person person2 = new Person("홍길순");

        Console.WriteLine(Person.CountOfInstance);  // 출력 결과: 2
    }
}