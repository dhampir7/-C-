/*4.3.1.1 as, is 연산자*/

int n = 5;
if (n is string)
{
    Console.WriteLine("변수 n은 string 타입");
}

string txt = "text";
if (txt is int)
{
    Console.Write("변수 txt는 int 타입");
}