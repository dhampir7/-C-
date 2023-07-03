/*예제 4.12 as의 잘못된 사용 예*/

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

int n = 5;
if ((n as string) != null)  // 컴파일 오류 발생
{
    Console.WriteLine("변수 n은 string 타입");
}

string txt = "text";
if ((txt as int) != null)   // 컴파일 오류 발생
{
    Console.WriteLine("변수 txt는 int 타입");
}

