using System.ComponentModel;

namespace CSharpStudy
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			int a = int.Parse(input);
			for(int i = 1; i < 10; i++)
			{
				Console.WriteLine(a + " X " + i + " = " + a * i);
			}
            //Console.WriteLine(a + " X " + 1 + " = " + a * 1);
            //Console.WriteLine(a + " X " + 2 + " = " + a * 2);
            //Console.WriteLine(a + " X " + 3 + " = " + a * 3);
            //Console.WriteLine(a + " X " + 4 + " = " + a * 4);
            //Console.WriteLine(a + " X " + 5 + " = " + a * 5);
            //Console.WriteLine(a + " X " + 6 + " = " + a * 6);
            //Console.WriteLine(a + " X " + 7 + " = " + a * 7);
            //Console.WriteLine(a + " X " + 8 + " = " + a * 8);
            //Console.WriteLine(a + " X " + 9 + " = " + a * 9);

            // For
            //for(변수 초기화, 조건식 , 반복후 실행되는 식)
            //증감 연산자 (++) = + 1;
            //int c = 0;
            //c++;// i = i + 1;
            //for(변수 초기화, 조건식 , 반복후 실행되는 식)
            //for (int i = 0; i < 5; i++)
            //{
            //    if (i == 2)
            //        continue;
            //    //if (i == 2)
            //    //	break;

            //    Console.WriteLine(i);
            //}
        }
	}
}
