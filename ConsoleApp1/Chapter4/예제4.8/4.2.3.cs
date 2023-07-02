/*4.2.3 프로퍼티*/

class Circle
{
    double pi = 3.14;

    public void set_Pi(double value)
    {
        this.pi = value;
    }

    public double get_Pi()
    {
        return this.pi;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle o = new Circle();
        o.Pi = 3.14159;             // 쓰기
        double piValue = o.Pi;      // 읽기
    }
}