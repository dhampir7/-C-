/*예제 4.3.2.4 GetHashCode*/

class Book
{
    decimal _isbn;

    public Book(decimal isbn)
    {
        _isbn = isbn;
    }
}
class Program
{
    static void Main(string[] args)
    {
        short n1 = 256;
        short n2 = 32750;
        short n3 = 256;

        Console.WriteLine(n1.GetHashCode());    // 출력 결과: 16777472
        Console.WriteLine(n2.GetHashCode());    // 출력 결과: 2146336750
        Console.WriteLine(n3.GetHashCode());    // 출력 결과: 16777472

        Book book1 = new Book(9788998139018);
        Book book2 = new Book(9788998139018);

        Console.WriteLine(book1.GetHashCode()); // 출력 결과: 46104728
                                                // [임의의 값으로 실행할 때마다 달라짐]
        Console.WriteLine(book2.GetHashCode()); // 출력 결과: 12289376
                                                // [임의의 값으로 실행할 때마다 달라짐]
    }
}
