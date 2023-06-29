/*위의 클래스에서는 new를 통해 객체가 생성될 때 "영희"라는 값을 생성자의 인자로 전달받는다.
이어서 생성자는 전달받은 값을 멤버 변수인 _name에 보관해 두고 이후에 클래스의 다른 멤버 메서드에서 사용한다.*/

class Person
{
    string _name;

    public Person(string name)
    {
        _name = name;
    }

    public void WriteName()
    {
        Console.WriteLine("Name: " + _name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("영희");
/*      Person person = new Person();   // 기본 생성자가 정의돼 있지 않아서 에러 발생*/
        person.WriteName();
    }
}