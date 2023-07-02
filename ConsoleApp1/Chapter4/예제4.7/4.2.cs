/*4.2 캡슐화*/

double pi = 3.14;

double GetAreaOfCircle(double radius)   // 원의 넓이를 반환하는 함수
{
    return radius * radius pi;
}

void Print(double value)
{
    Console.WriteLine(GetAreaOfCircle(value));
}

Print(10);  // 출력 결과: 314