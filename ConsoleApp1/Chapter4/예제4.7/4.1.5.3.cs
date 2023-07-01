/*4.1.5.3 정적 생성자*/

class Person
{
    static public Person President; // = new Person("대통령") 초기화 코드를
                                    // 정적 생성자로 이전해서 컴파일
    string _name;

    private Person(string name) // private 인스턴스 생성자
    {
        _name = name;
    }

    static Person() // 정적 생성자
    {
        President = new Person("대통령");  // 정적 필드 초기화
    }
}