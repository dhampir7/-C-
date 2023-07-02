/*4.3 상속*/

public class Notebook : Computer
{
    bool fingerScan;
    public bool HasFingerScanDevice() { return fingerScan; }

    public void CloseLid()
    {
        Shutdown();     // Notebook에서 추가된 메서드 내에서 부모의 메서드 호출
    }
}

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            notebook.Boot();    // Notebook 인스턴스에 대해 부모의 메서드 호출
        }
    }
}