/*4.2 캡슐화*/

class Circle
{
    double pi = 3.14;

    double GetArea(double radius)
    {
        return radius * radius * pi;
    }

    public void Print(double value)
    {
        Console.WriteLine(GetArea(value));
    }
}