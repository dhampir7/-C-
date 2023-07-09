/*4.3.5 base*/

class Book
{
    decimal isbn13;

    public Book(decimal isbn13)
    {
        this.isbn13 = isbn13;
    }
}

class EBook : Book
{
    public EBook() : base(0)
    {
    }

    public EBook(decimal isbn)  // 또는 이렇게 값을 연계하는 것도 가능하다.
        : base(isbn)
    {
    }
}