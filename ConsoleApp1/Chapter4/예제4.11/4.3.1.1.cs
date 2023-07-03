/*4.3.1.1 as, is 연산자*/

public class Computer
{
    bool powerOn;
    public void Boot() { }
    public void Shutdown() { }
    public void Reset() { }
}

public class Notebook : Computer
{
    bool fingerScan;
    public bool HasFingerScanDevice() { return fingerScan; }

    public void CloseLid()
    {
        if (powerOn == true) // 컴파일 가능
        {
            Shutdown(); // Notebook에서 추가된 메서드 내에서 부모의 메서드 호출
        }
    }
}

public class Desktop : Computer
{
}

Computer pc = new Computer();
Notebook notebook = pc as Notebook;

if (notebook != null)   // 코드대로라면 if 문 내부의 코드가 실행될 가능성은 없다.
{
    notebook.CloseLid();
}

