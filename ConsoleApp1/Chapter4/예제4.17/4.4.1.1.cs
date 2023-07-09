/*4.4.1.1 base를 이용한 메서드 재사용*/

using System;

public class Computer
{
    virtual public void Boot()
    {
        Console.WriteLine("메인보드 켜기");
    }
}

public class Notebook : Computer
{
    public override void Boot()
    {
        Console.WriteLine("메인보드 켜기");
        Console.WriteLine("액정 화면 켜기");
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.Boot();

            Notebook notebook = new Notebook();
            notebook.Boot();
        }
    }