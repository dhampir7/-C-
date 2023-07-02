/*4.3 상속*/

public class Notebook : Computer
{
    bool fingerScan;
    public bool HasFingerScanDevice() { return fingerScan; }

    public void CloseLid()
    {
        if (powerOn == true)    // 컴파일 오류 발생: 접근 불가(inaccessible)
        {
            Shutdown();
        }
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