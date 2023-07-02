/*4.3 상속*/

public class Compuber
{
    protected bool powerOn;
    public void Boot() { }
    public void Shutdown() { }
    public void Reset() { }
}

public class Notebook : Computer
{
    //  ......[생략]......
}