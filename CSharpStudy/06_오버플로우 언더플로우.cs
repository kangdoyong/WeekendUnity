using System.ComponentModel;

namespace CSharpStudy
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 오버플로우와 언더 플로우
			// 데이터를 선언 해당 데이터 크기
			// 정수형 데이터 타입
			// int => 4바이트
			// long => 8바이트
			// short => 2바이트 
			// byte => 1바이트

			int maxInt = int.MaxValue;
			int minInt = int.MinValue;

			int overflow = maxInt + 1;
			int underflow = minInt - 1;

            Console.WriteLine("int의 최댓값 :" + maxInt);
            Console.WriteLine("int의 최솟값 :" + minInt);
			Console.WriteLine("오버플로우 :" + overflow);
			Console.WriteLine("언더플로우 :" + underflow);
		}
	}
}
