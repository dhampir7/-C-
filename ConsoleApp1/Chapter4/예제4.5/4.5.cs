/*생성자를 여러 개 정의하는 것도 가능하다. 
예를 들어, Book 클래스에 다음과 같은 생성자를 제공할 수 있다.*/

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