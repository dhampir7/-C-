/*매번 이렇게 객체를 생성할 때마다 네임스페이스를 함께 지정해야 하는 것은 여간 번거로운 일이 아닐 수 없다.
이 때문에 C#은 using이라는 예약어를 추가했고,
다음과 같이 네임스페이스를 미리 선언해 두면 객체를 생성할 때 이를 생략해도 
C# 컴파일러가 알아서 객체가 속한 네임스페이스를 찾아내어 오류 없이 컴파일한다.*/

using Communication
using Disk.FileSystem;

namespace Communication
{

}
