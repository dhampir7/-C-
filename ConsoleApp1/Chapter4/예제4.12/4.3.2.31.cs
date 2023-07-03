/*4.3.2.2 Equals*/

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 5;
            int n2 = 5;
            Console.WriteLine(n1.Equals(n2));   // 출력 결과: True

            n2 = 6;
            Console.WriteLine(n1.Equals(2));    // 출력 결과: False
        }
    }
}