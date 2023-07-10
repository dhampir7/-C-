/*예제 4.18 ToString을 재정의한 Point*/

using System;

delegate int GetResultDelegate();   // int를 반환하고 매개변수가 없는 델리게이트 타입을 정의

class Target
{
    public void Do(GetResultDelegate getResult)
    {
        Console.WriteLine(getResult()); // 콜백 메서드 호출
    }
}

class Source
{
    public int GetResult()  // 콜백 용도로 전달될 메서드
    {
        return 0;
    }

    public void Test()
    {
        Target target = new Target();
        target.Do(new GetResultDelegate(this.GetResult));
    }
}

class Program
{
    // 3개의 매개변수를 받고 void를 반환하는 델리게이트 정의
    // 매개변수의 타입이 중요할 뿐 매개변수의 이름은 임의로 정할 수 있음.
    delegate void WorkDelegate(char arg1, int arg2, int arg3);
    static void Main(string[] args)
    {
        Mathematics math = new Mathematics();
        WorkDelegate work = math.Calculate;

        work('+', 10, 5);
        work('-', 10, 5);
        work('*', 10, 5);
        work('/', 10, 5);
    }
}