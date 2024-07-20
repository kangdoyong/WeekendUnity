using System.ComponentModel;

namespace CSharpStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 구구단 3단

            //문자열 데이터 타입
            //[문자][문자][문자][문자]
            //[char][char][char][char] = 문자열 데이터 타입
            //[H][e][l][l][o] + [W][o][r][l][d] = [H][e][l][l][o][ ][W][o][r][l][d][1][0][0]

            //Console.WriteLine(result);

            // 3 X 1 = 결과
            //3(숫자) X(문자) 1(숫자) =(문자) 결과(숫자);
            // [3][ ][X][ ][1][ ][=][ ][3 * 1];

            // 입력 받기
            //string input = Console.ReadLine();

            //Console.WriteLine(input);

            //사용자의 입력 값에 따라서 구구단 출력하기:
            // 사용자가 "1" 입력하면
            // 1단이 출력
            // 사용자가 "3" 입력하면
            // 3단이 출력
            // 코드를 구현
            string input = Console.ReadLine();
            int a = int.Parse(input);
            Console.WriteLine(a + " X " + 1 + " = " + a * 1);
            Console.WriteLine(a + " X " + 2 + " = " + a * 2);
            Console.WriteLine(a + " X " + 3 + " = " + a * 3);
            Console.WriteLine(a + " X " + 4 + " = " + a * 4);
            Console.WriteLine(a + " X " + 5 + " = " + a * 5);
            Console.WriteLine(a + " X " + 6 + " = " + a * 6);
            Console.WriteLine(a + " X " + 7 + " = " + a * 7);
            Console.WriteLine(a + " X " + 8 + " = " + a * 8);
            Console.WriteLine(a + " X " + 9 + " = " + a * 9);
        }
    }
}
