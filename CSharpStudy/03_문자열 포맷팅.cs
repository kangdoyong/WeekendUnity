using System.ComponentModel;

namespace CSharpStudy
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 문자열 포맷팅 => 우리가 원하는 문자열로 바꾸는 것

			int a = 10;
			//[1][0][ ][*][ ][5][ ][=][ ][a * 5]
			//Console.WriteLine("10 * 5 = " + a * 5);

			//[a * 5][ ][*][ ][5][ ][=][ ]
			string str = string.Format("{0} * 5 = ", a * 5);

			//[{0}][ ][*][ ][{1}][ ][=][ ][{2}]
			//[a][ ][*][ ][5][ ][=][ ][a * 5]
			string str2 = string.Format("{0} * {1} = {2}", a ,5,a * 5);
			// 100만
			// 10만
			int damage = 1000;
			string str3 = string.Format("{0}만", damage);

			string str4 = $"{damage}만";
			Console.WriteLine(str3);
			Console.WriteLine(str4);
		}
	}
}
