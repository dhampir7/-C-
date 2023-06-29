/*두 가지 변경 사항이 눈에 띈다. 우선 
1) 필드 정의에 static 예약어가 붙었으며
2) 클래스 밖에서 이 필드를 사용할 때 [클래스이름].[정적필드] 형태로 접근했다.
실행 결과에서 보다시피 정적 필드의 값은 new로 할당된 인스턴스와 상관없이 존재한다.*/

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