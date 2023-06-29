/*클래스로 정의된 타입은 string처럼 모두 "참조형"으로 분류되므로 Book 타입을 사용하려면 우선 new 연산자로 메모리 할당을 해야 함*/

class Book
{
	string Title;
	decimal ISBN13;
	string Contents;
	string Author;
	int PageCount;
}