using System.ComponentModel;

namespace CSharpStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 캐스팅 파싱
            // 캐스팅 :  데이터 타입을 변환하다.
            // 파싱 : 데이터를 구분 분석해서 원하는 값을 추출하는 과정.
            //[1][2][3][4][5][6][7][8]
            // 0  0  0  0  0  0  0  0
            // 12345678

            string input = console.readline();
            int result = int.parse(input);
            float result2 = float.parse(input);
            double result3 = double.parse(input);
            short result4 = short.parse(input);
            long result5 = long.parse(input);

            console.writeline(result);
            console.writeline(result2);
            console.writeline(result3);
            console.writeline(result4);
            console.writeline(result5);
        }
    }
}
