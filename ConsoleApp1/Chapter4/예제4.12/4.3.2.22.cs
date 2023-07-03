/*4.3.2.2 GetType*/

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(double);
            Console.WriteLine(type.FullName);

            Console.WriteLine(typeof(System.Int16).FullName);
        }
    }
}