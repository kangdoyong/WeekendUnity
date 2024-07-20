using System;

public class Program
{
	public static void Main(string[] args)
	{
		// 다차원 배열
		// 2차원 이상의 배열
		// => 행렬, 그리드 형태의 데이터를 저장하고 관리할 때 쓰이는 데이터 구조
		//int[] arr = { 1, 2, 3 };
		int[,] matrix = { };
		int[,] matrix2 =
		{
			//0  1  2
			{ 1, 2, 3 }, // 0번째 인덱스 배열
			{ 4, 5, 6 }, // 1번째 인덱스 배열
			{ 7, 8, 9 }, // 2번쨰 인덱스 배열 
		};

		// 특정 요소에 접근하여 출력
		Console.WriteLine("특정 요소 출력 : " + matrix2[0,1]);

		// 2차원 배열의 모든 요소를 순회하여 출력
		for (int y = 0; y < 3; y++)
		{
			for (int x = 0; x < 3; x++)
			{
				Console.WriteLine(matrix2[y,x]);
			}
		}

		// 다중 반복문
		//for(int i = 0; i < 5; i++)
		//{
		//	for(int j = 0; j < 5; j++) 
		//	{
		//              Console.WriteLine("I : " + i + " J : " + j);
		//          }
		//}

	}
}
