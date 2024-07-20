using System;

public class Program
{
	public static void Main(string[] args)
	{
		// Dictionary 
		// 키- 값을 쌍으로 데이터를 저장하고 관리하는 데 사용하는 데이터 구조입니다.
		// 다양한 타입의 키와 값을 유연하게 처리할 수 있습니다.
		// 배열에서는 무조건 Index로 값을 찾습니다. => Index == Key

		// 특징
		// 1, 키-값 쌍으로 데이터를 저장하고 관리합니다.
		// => 해당 키를 통해서 값에 접근할 수 있습니다.
		// 2, 고유한 키값을 가진다. => 중복된 키값은 안된다.
		// 3, 동적으로 크기를 조정 할 수 있다.

		// 문자열 키와 문자열 값을 가지는 Dictionary 생성
		Dictionary<string,string> capitals 
			= new Dictionary<string, string>();

		// 키 - 값 쌍으로 추가
		capitals.Add("South Korea", "Seoul");
		capitals.Add("United States", "Washington D.C.");
		capitals.Add("United Kingdom", "London");

		// 키 값을 통한 접근
		Console.WriteLine(capitals["South Korea"]);

		// 딕션어리 순회
		// 딕션어리에 있는 모든 Value(값)을 가져온다.
		foreach(string str in capitals.Values)
		{
            Console.WriteLine(str);
        }

		foreach (string str in capitals.Keys)
		{
			Console.WriteLine(str);
		}

		foreach (KeyValuePair<string,string> str in capitals)
		{
			Console.WriteLine(str.Key + " : " + str.Value);
		}

		// 키 존재 여부 확인
		if (capitals.ContainsKey("France"))
		{
            Console.WriteLine("Dictionary has key : France");
        }
		else
		{
			Console.WriteLine("Dictionary has Not key : France");
		}
		// 값 존재 여부 확인
		if (capitals.ContainsValue("Seoul"))
		{
			Console.WriteLine("Dictionary has value : Seoul");
		}
		else
		{
			Console.WriteLine("Dictionary has Not value : Seoul");
		}
		// 키 - 값 쌍으로 존재 여부 확인
		if (capitals.Contains(new KeyValuePair<string,string>("South Korea", "Seoul")))
		{
			Console.WriteLine("Dictionary has KeyValuePair : South Korea : Seoul");
		}
		else
		{
			Console.WriteLine("Dictionary has Not KeyValuePair : South Korea : Seoul");
		}

		// 예외 처리가 들어간 키에 해당하는 값을 가져오기
		if (capitals.ContainsKey("United States"))
		{
			Console.WriteLine(capitals["United States"]);
		}

		// 예외 처리가 들어간 키에 해당하는 값을 가져오기
		if (capitals.TryGetValue("United States", out string value))
		{
			Console.WriteLine(value);
		}

		//List<string> list = new List<string>();
		//list.Add("Seoul");
		//list.Add("Washington D.C.");
		//list.Add("London");

		//foreach (string str in list)
		//{
		//	Console.WriteLine(str);
		//}
	}
}
