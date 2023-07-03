/*4.3.1 형변환*/

//  ......[생략]......

public class DeviceManager
{
    public void TurnOff(Computer device)
    {
        device.Shutdown();
    }
}

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            Desktop desktop = new Desktop();
            Netbook netbook = new Netbook();

            DeviceManager manager = new DeviceManager();
            manager.TurnOff(notebook);
            manager.TurnOff(desktop);
            manager.TurnOff(netbook);
        }
    }
}