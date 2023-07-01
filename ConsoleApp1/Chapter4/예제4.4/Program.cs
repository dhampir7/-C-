/*예제 4.4 매개변수를 갖는 생성자*/

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