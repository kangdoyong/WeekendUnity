using System.ComponentModel;

namespace CSharpStudy
{
	internal class Program
	{
		// 열거형
		// 열거형은 상수들의 집합을 정의하는 데 사용됩니다.
		enum DAYS
		{
			Monday,
			Tuesday,
			Wednesday,
			Thursday,
			Friday,
			Saturday,
		}
		static void Main(string[] args)
		{
			// 코드 흐름 제어하기
			// If 조건문
			// if(조건 => 논리 연산자,비교연산자, bool 데이터)
			//{
			//		조건이 true일 때 실행할 코드
			//}

			//int number = 5;
			//if (number > 0)// 조건이 true일때
			//{
			//	Console.WriteLine("Number is greater than 0");
			//}
			//else if (number < 0)// 조건이 true일때
			//{
			//	Console.WriteLine("Number is Less than 0");
			//}
			//else// 위에 있는 조건들이 전부 false일때
			//{
			//	Console.WriteLine("Number is Equal 0");
			//}

			// Switch 문
			// 여러 조건들 중에서 하나를 선택하여 실행하는 조건문입니다.
			// 여러 값이나 상태에 따라서 다른 동작을 수행해야 할 때 사용합니다.
			// switch(변수)
			//{
			//	  case 값:
			//		break;
			//}

			int day = 100;
			switch (day)
			{
				case 1:// day == 1 => true
					Console.WriteLine("Monday");
					break;
				case 2:// day == 2 => true
					Console.WriteLine("Tuesday");
					break;
				case 3:// day == 3 => true
					Console.WriteLine("Wednesday");
					break;
				case 4:// day == 4 => true
					Console.WriteLine("Thursday");
					break;
				case 5:// day == 5 => true
					Console.WriteLine("Friday");
					break;
				default://위에 있는 case들 전부 맞지 않을 때 
					Console.WriteLine("Wrong Value");
					break;
			}



		} 
	}
}
