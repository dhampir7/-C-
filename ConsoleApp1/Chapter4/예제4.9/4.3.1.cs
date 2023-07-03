/*4.3.1 형변환*/

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
}

public class Desktop : Computer
{
}

Notebook noteBook = new Notebook();

Computer pc1 = noteBook;    // 암시적 형변환 가능
pc1.Boot();
pc1.Shutdown();