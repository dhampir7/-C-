/*4.3 상속*/

public class Notebook
{
    bool powerOn;
    public void Boot() { }
    public void Shutdown() { }
    public void Reset() { }

    bool fingerScan;    // Notebook 특화 멤버 필드 추가
    public bool HasFingerScanDevice()   // Notebook 특화 멤버 메서드 추가
    {
        return fingerScan;
    }
}

public class Desktop
{
    bool powerOn;
    public void Boot() { }
    public void Shutdown() { }
    public void Reset() { }
}

public class Netbook
{
    bool powerOn;
    public void Boot() { }
    public void Shutdown() { }
    public void Reset() { }
}