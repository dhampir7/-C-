/*예제 4.11 배열 요소에서의 암시적 형변환*/

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

Computer[] machines =
    new Computer[] { new Notebook(), new Desktop(), new Netbook() };    // 암시적 형변환

DeviceManager manager = new DeviceManager();

foreach (Computer device in machines)
{
    manager.TurnOff(device);
}

