/*이제 위의 코드가 눈에 들어올 것이다. 
그동안 빈번하게 사용해온 Console.WriteLine은 다름 아닌 Console 클래스에 정의된 WriteLine 정적 메서드를 가리킨다.
그리고 Main 메서드도 정적 메서드에 속하지만 C#에서 다소 특별한 대우를 받기 때문에 좀 더 부가적인 설명이 필요하다.*/

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) // Main 정적 메서드 정의
        {
            // 문자열 출력
            Console.WriteLine("Hello World");   // Console 타입에 정의된 정적 메서드 사용
        }
    }
}
