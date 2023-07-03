/*4.3.2.2 GetType*/

public class Computer
{
    bool powerOn;
    public void Boot() { }
    public void Shutdown() { }
    public void Reset() { }
}

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            string txt = "text";

            Type intType = n.GetType();

            Console.WriteLine(intType.FullName);
            Console.WriteLine(txt.GetType().FullName);
        }
    }
}