/*4.3.4 this*/

class Book
{
    decimal isbn;

    public Book(decimal isbn)
    {
        this.isbn = isbn;   // this를 생략하면 메서드의 매개변수인 isbn 변수가 사용된다.
    }
}