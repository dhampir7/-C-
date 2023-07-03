/*예제 4.3.2.2 GetType*/

class Program
{
    static void Main(string[] args)
    {
        string txt1 = new string(new char[] { 't', 'e', 'x', 't' });
        string txt2 = new string(new char[] { 't', 'e', 'x', 't' });

        Console.WriteLine(txt1.Equals(txt2));   // 출력 결과: True
    }
}
