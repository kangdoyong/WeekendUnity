using System.IO.Pipes;

namespace ConsoleApp1
{
	internal class Program
	{
		// Static 
		// 정적 멤버를 선하는 데 사용되며, 객체 인스턴스가 아닌 클래스 자체에 속한 멤버를 정의합니다.
		class Character
		{
			public static int ID = 0;
			public int Index;
            public Character()
            {
				ID += 1;
                Console.WriteLine("Character ID is " + ID);
            }

			public static void Run()
			{
				Console.WriteLine("Character Is Run");
				//Index = 0;
				ID = 0;
			}
        }

		static void Main(string[] args)
		{
			Character character = new Character();
			Character.ID = 10;
			Character character2 = new Character();

			Character.Run();
		}
	}
}
