/*Main 메서드에서 0 이외의 다른 값을 반환하면 %ERRORLEVEL% 값 역시 그에 따라 바뀐다.
일반적으로 프로그램이 정상적으로 실행돼 종료하면 0을 반환하고, 오류가 발생한 경우에는 오류의 종류에 따라 숫자값을 정해서 반환한다

그럼 Main 메서드의 인자로 허용되는 string 배열은 어떻게 사용될 수 있을까? 
명령해에서 EXE 프로그램을 실행할 때 함께 입력되는 문자열을 차례대로 배열에 담아 활용하는 것이 가능하다*/

class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            return;
        }

        Console.WriteLine(args[0]);
        Console.WriteLine(args[1]);
    }
}