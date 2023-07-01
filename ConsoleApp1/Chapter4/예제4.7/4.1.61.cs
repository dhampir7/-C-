/*이렇게 네임스페이스를 적용해 두면 해당 클래스가 어디에 있는지 좀 더 직관적으로 찾을 수 있다.
하지만 여기에 작은 문제가 하나 있다. 
위의 클래스를 네임스페이스가 다른 우리의 예제코드에서 사용하려면 다음과 같은 식으로 다소 긴 코드를 작성해야 한다.*/

namespace Communication
{
    class Http
    {
    }

    class Ftp
    {
    }
}

namespace Disk.FileSystem
{
    class File
    {
    }
}
