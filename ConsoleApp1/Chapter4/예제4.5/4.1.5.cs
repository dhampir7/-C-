/*4.1.5 정적 멤버, 인스턴스 멤버 ) 어떤 타입을 실체화한 객체를 인스턴스라고 한다.
인스턴스를 달리 표현하면 new 연산자를 거쳐서 메모리에 할당된 객체라고 할 수 있다.
바로 그 객체와 관련된 멤버를 인스턴스 멤버(instance member)라고 하며, 지금까지 설명한 필드, 메서드, 생성자는 모두 여기에 속한다.*/

class Person
{
    public string _name;    // 인스턴스 필드

    public Person(string name)  // 인스턴스 생성자
    {
        _name = name;
    }

    public void OutputYourName()    // 인스턴스 메서드
    {
        Console.WriteLine(_name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("홍길동");  // new를 통해 인스턴스 생성자에 접근
        person.OutputYourName();    // new로 생성된 객체의 인스턴스 메서드를 호출
        Console.WriteLine(person._name);    // new로 생성된 객체의 인스턴스 필드에 접근
    }
}