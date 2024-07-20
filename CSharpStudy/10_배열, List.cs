using System;

public class Program
{
	public static void Main(string[] args)
	{
        // 배열
        // 같은 타입의 여러 데이터를 하나의 변수에 순서대로 저장하기 위한 데이터 구조입니다.
        // 배열을 사용하면 하나의 이름으로 여러 데이터를 관리 할 수 있습니다.
        // 인덱스를 사용해서 각 요소에 접근할 수 있습니다.
        // 배열의 특징
        // 1, 동일한 데이터 타입만 저장할 수 있습니다.
        // 2, 고정된 크기 값을 가집니다. => 그 크기를 벗어나는 오류 : IndexOutOfRange
        // 3, 인덱스 접근이 가능하다. => 각 인덱스에 해당하는 값을 가져오거나 변경할 수 있다.
        // => 인덱스는 항상 0부터 시작한다.
        // 4, 순차적으로 메모리를 할당합니다.

        int[] numbers = { 1, 2, 3, 4, 5 };

        Console.WriteLine(numbers[0]);
        Console.WriteLine(numbers[1]);
        Console.WriteLine(numbers[2]);
        Console.WriteLine(numbers[3]);
        Console.WriteLine(numbers[4]);
        //Console.WriteLine(numbers[5]);

        for (int i = 0; i < numbers.Length; i++)
        {

            numbers[i] += 5;
        }

        Console.WriteLine(numbers[0]);
        Console.WriteLine(numbers[1]);
        Console.WriteLine(numbers[2]);
        Console.WriteLine(numbers[3]);
        Console.WriteLine(numbers[4]);

        // 5명의 학생 이름을 저장할 수 있는 문자열 배열을 생성하고, 각각에 학생 이름을 할당하세요.
        // 배열의 모든 학생 이름을 출력하세요.


        // List
        // 동적으로 크기가 조절되는 배열을 제공하는 데이터 구조입니다.
        // 주요 특징
        // 1, 동적 크기 지원 : 요소의 추가 및 제거에 따라서
        //					  배열의 크기가 자동으로 조절됩니다.
        // 2, 인덱스 접근이 가능하다. => 각 인덱스에 해당하는 값을 가져오거나 변경할 수 있다.
        // => 인덱스는 항상 0부터 시작한다.
        // 3, 함수를 지원한다. => 배열의 요소의 추가, 삭제, 검색, 정렬 등 다양한 함수를 제공합니다.

        string[] fruitArr =
		{
			"Apple",
			"Banana",
			"Cherry"
		};

		//List<string> fruits = new List<string>
		//{
		//	"Apple",
		//	"Banana",
		//	"Cherry"
		//};
		List<string> fruits = new List<string>();
		fruits.Add("Apple");
		fruits.Add("Banana");
		fruits.Add("Cherry");

		//인덱스를 통한 접근
		Console.WriteLine(fruits[1]);

		for(int i = 0; i < fruits.Count; i++)
		{
			Console.WriteLine(fruits[i]);
		}

		// 요소 제거
		fruits.Remove("Banana");
        Console.WriteLine("Remove Banana");
        for (int i = 0; i < fruits.Count; i++)
		{
			Console.WriteLine(fruits[i]);
		}

		// 요소 삽입
		fruits.Insert(1, "Mango");
        Console.WriteLine("Insert Mango");
		for (int i = 0; i < fruits.Count; i++)
		{
			Console.WriteLine(fruits[i]);
		}

		Console.WriteLine(fruits.Count);

		//리스트에 특정 요소가 있는지 확인
		Console.WriteLine("리스트에 특정 요소가 있는지 확인" + fruits.Contains("Banana"));
		Console.WriteLine("리스트에 특정 요소가 있는지 확인" + fruits.Contains("Mango"));

		fruits.Sort();
		Console.WriteLine("Sort 정렬 이후");
		for (int i = 0; i < fruits.Count; i++)
		{
			Console.WriteLine(fruits[i]);
		}

		fruits.Clear();
		Console.WriteLine(fruits.Count);

		List<string> list = fruitArr.ToList();
		fruits.Add("Apple");
		fruits.Add("Banana");
		fruits.Add("Cherry");
		string[] arr = fruits.ToArray();

	}
}
