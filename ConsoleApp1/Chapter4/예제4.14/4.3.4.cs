/*4.3.4 this*/

class Book
{
    decimal _isbn;
    public decimal ISBN
    {
        get { return this._isbn; }
    }

    public Book(decimal isbn)
    {
        this._isbn = isbn;
    }

    public decimal GetISBN()
    {
        return this._isbn;
    }

    public void Sell()
    {
        Console.WriteLine("Sell: " + this.GetISBN());
    }
}