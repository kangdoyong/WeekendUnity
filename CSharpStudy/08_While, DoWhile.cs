using System.ComponentModel;

namespace CSharpStudy
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 반복문
			// While
			// while(조건) => 조건 true 계속 반복적으로 실행
			int a = 1;
			int b = 10;
			// 무한 반복 : while(조건)문에 조건이 항상 true일때
			// 계속 while문이 호출되는 상황
			while(a < b) //조건 true 계속 반복적으로 실행
			{
				if (a == 5)
					break;
				Console.WriteLine(a);
				a = a + 1;
			}

			//// Do-while 문은 Do에 선언된 코드를 무조건 한번 실행하고 조건은 비교한다.
			//do
			//{
			//	Console.WriteLine("Do While");// Do에 선언된 코드
			//} while(false);//조건은 비교한다.
		}
	}
}
