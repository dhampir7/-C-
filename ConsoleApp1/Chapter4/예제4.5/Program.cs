/*예제 4.5 생성자를 여러 개 사용*/

class Book
{
    public string Title;
    public decimal ISBN13;
    public string Autor;

    public Book(string title)
    {
        Title = title;
    }

    public Book(string title, decimal isbn13)
    {
        Title = title;
        ISBN13 = isbn13;
    }

    public Book(string title, decimal iSBN13, string autor)
    {
        Title = title;
        ISBN13 = iSBN13;
        Autor = autor;
    }
}