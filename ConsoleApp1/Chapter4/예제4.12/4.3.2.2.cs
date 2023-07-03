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
            Computer computer = new Computer();
            Type type = computer.GetType();

            Console.WriteLine(type.FullName);   // Type 클래스의 FullName 프로퍼티 호출
            Console.WriteLine(type.IsClass);    // Type 클래스의 IsClass 프로퍼티 호출
            Console.WriteLine(type.IsArray);    // Type 클래스의 IsArray 프로퍼티 호출
        }
    }
}