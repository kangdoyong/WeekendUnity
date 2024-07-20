using System.ComponentModel;

namespace CSharpStudy
{
	internal class Program
	{
		// 함수 : 특정 작업을 수행하는 코드 블록
		// 함수 선언 문법 : 반환타입 함수 이름
		// 반환타입 
		// 함수를 실행한 결과를 반환하는 데이터 타입
		// static int PrintHelloWorld() => int값을 무조건 반환한다.
		// static float PrintHelloWorld() => float값을 무조건 반환한다.
		// static string PrintHelloWorld() => string값을 무조건 반환한다.
		// static void PrintHelloWorld() => 값을 반환하지 않는다.
		//static void PrintHelloWorld()
		//{
		//	Console.WriteLine("Hello World");
		//}

		// 오버로딩 : 같은 이름의 함수를 다른 함수로 정의해서 사용하는 기능

		//static int IntFunction() => int값을 무조건 반환한다.
		static int IntFunction()
		{
			return 10;
		}
		static int IntFunction(int a) // a : 매개변수
		{
			return 10;
		}
		static int IntFunction(int a,int b) // a : 매개변수
		{
			return 10;
		}
		//static float FloatFunction() => float값을 무조건 반환한다.
		static float FloatFunction()
		{
			return 0.5f;
		}
		//static string StringFunction() => string값을 무조건 반환한다.
		static string StringFunction()
		{
			return "Hello World";
		}

		// 사칙연산 함수들
		// 두개 수를 넘겨주면 두개 수를 더한 값을 반환 해주는 함수
		static int AddFunction(int num1, int num2)
		{
			return num1 + num2;
		}

		// 두개 수를 넘겨주면 두개 수를 뺀 값을 반환 해주는 함수
		// 함수 이름 : MinusFuncion
		static int MinusFuncion(int num1, int num2)
		{
			return num1 - num2;
		}

		// 두개 수를 넘겨주면 두개 수를 곱합 값을 반환 해주는 함수
		// 함수 이름 : MuliflyFuncion
		static int MuliflyFuncion(int num1, int num2)
		{
			return num1 * num2;
		}

		// 두개 수를 넘겨주면 첫번째 수를 두번째 수로 나눈 몫 값을 반환 해주는 함수
		// 함수 이름 : DivideFuncion
		static int DivideFuncion(int num1, int num2)
		{
			return num1 / num2;
		}

		static void Main(string[] args)
		{
            Console.WriteLine(AddFunction(1,10));
			Console.WriteLine(MinusFuncion(1, 10));
			Console.WriteLine(MuliflyFuncion(1, 10));
			Console.WriteLine(DivideFuncion(1, 10));
		}
	}
}
