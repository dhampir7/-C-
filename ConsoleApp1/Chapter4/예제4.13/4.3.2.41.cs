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
        int n1 = 256;
        int n2 = 2147483647;

        Console.WriteLine(n1.GetHashCode());    // 출력 결과: 256
        Console.WriteLine(n2.GetHashCode());    // 출력 결과: 2147483647
    }
}
