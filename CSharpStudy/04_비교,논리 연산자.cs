using System.ComponentModel;

namespace CSharpStudy
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// bool 데이터 타입과 비교 연산자 논리 연산자
			// bool => true, false => 1,0
			//
			// 비교 연산자
			// 동등(==) : 두개의 피연산자의 값이 같은지를 비교합니다. 
			//			같다면 true, 다르다면 false값을 반환합니다 =>bool형 데이터로 반환
			// 부등(!=) : 두개의 피연산자의 값이 다른지를 비교합니다.
			//			다르다면 true, 같다면 false값을 반환합니다.
			// 크다(>) : 왼쪽 피연산자가 오른쪽 피연산자보다 큰지 비교합니다.(초과)
			//			크다면 true, 아니면 false 값을 반환합니다.
			// 작다(<) : 왼쪽 피연산자가 오른쪽 피연산자보다 작은지 비교합니다.(미만)
			//			작다면 true, 아니면 false 값을 반환합니다.
			// 크거나 같다(>=) : 왼쪽 피연산자가 오른쪽 피연산자보다 크거나 같은지 비교합니다.(이상)
			//			크거나 같다면 true, 아니면 false 값을 반환합니다.
			// 작거나 같다(<=) : 왼쪽 피연산자가 오른쪽 피연산자보다 작거나 같은지 비교합니다.(이하)
			//			작거나 같다면 true, 아니면 false 값을 반환합니다.

			// 논리 연산자
			// And(&&) : 두가지 이상 조건이 true일때 true값을 반환합니다. (예: 나보다 키가 크고 남성인 사람)
			// Or(||) : 두가지 이상의 조건 중 하나라도 true일 때 true값을 반환합니다. (예: 나보다 키가 크거나 남성인 사람)
			// Not(!) : 조건의 결과를 반대로 바꿉니다. => (예: 나보다 키가 크고 남성인 사람) => 나보다 키가 작고 여성인 사람

			bool isTaller = false;
			bool isMan = false;
			bool result = isTaller || !isMan;
            Console.WriteLine(result);


            //bool isEqual = 10 == 5; // false
            //bool isNotEqual = 10 != 5; // true
            //bool isGreaterThan = 10 > 5; // true
            //bool isLessThan = 10 < 5; // false
            //bool isGreaterThanEqual = 10 >= 5; // true
            //bool isLessThanEqual = 10 <= 5; // false

            //Console.WriteLine(isEqual);
            //Console.WriteLine(isNotEqual);
            //Console.WriteLine(isGreaterThan);
            //Console.WriteLine(isLessThan);
            //Console.WriteLine(isGreaterThanEqual);
            //Console.WriteLine(isLessThanEqual);
        }
	}
}
