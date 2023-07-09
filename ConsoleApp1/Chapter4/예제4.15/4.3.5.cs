﻿/*4.3.5 base*/

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
        base.Shutdown();    // base 예약어를 명시
    }
}
