/*4.1.6 네임스페이스*/

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Communication.Http http = new Communication.Http();
            Disk.FileSystem.File file = new Disk.FileSystem.File();
        }
    }
}
