/*메서드 안에서 사용되는 return 문은 값을 반환하는 목적 말고도 점프 구문의 역할도 수행한다.
예를 들어, 다음 코드는 메서드를 실행하는 중간에 return 문을 사용해 실행 순서를 제어한다.*/

using System;

namespace ConsoleApp1
{
    public void WriteIf(bool output, string txt)
    {
        if (output == false)
        {
            return;
        }

        Console.WriteLine(txt);
    }
}