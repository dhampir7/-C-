/*클래스를 이렇게 정의해 두면 외부에서 new Person(......) 구문을 사용할 수 없다.
하지만 내부에서는 이미 정적 필드에 인스턴스를 생성해 뒀기 때문에 이후 Person.President와 같은 방법으로만 해당 객체를 사용할 수 있다.*/

class Person
{
    static public Person President = new Person("대통령"); // public 정적 필드
    string _name;

    private Person(string name) // private 인스턴스 생성자
    {
        _name = name;
    }

    public void DisplayName()   // public 인스턴스 메서드
    {
        Console.WriteLine(_name);
    }
}