/*우리가 원하는 결과는 해당 클래스에 속한 인스턴스가 생성된 총 횟수를 나타내는 것으로서 위에서는 마지막 값이 2가 되기를 기대했을 것이다.
하지만 인스턴스 필드는 new로 할당받은 객체마다 고유하게 메모리를 확보하기 때문에 클래스 전역적으로 값이 유지되지 않는다.
이 같은 요구사항을 만족하려면 클래스 단위의 필드를 정의해야 하고, 그것이 바로 정적 필드(static field)가 된다.*/

class Person
{
    public int CountOfInstance;

    public string _name;

    public Person(string name)
    {
        CountOfInstance++;  // 생성자에서 필드 값 증가
        _name = name;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person("홍길동");
        Console.WriteLine(person1.CountOfInstance); // 출력 결과: 1

        Person person2 = new Person("홍길순");
        Console.WriteLine(person2.CountOfInstance); // 출력 결과: 1
    }
}