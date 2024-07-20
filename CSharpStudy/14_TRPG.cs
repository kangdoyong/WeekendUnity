﻿using System.IO.Pipes;

namespace ConsoleApp1
{
	internal class Program
	{
		// TRPG
		class Character
		{
			// 캐릭터의 이름
			protected string Name;
			// 캐릭터의 체력
			public int HP;
			// 캐릭터의 공격력
			protected int ATk;

			public string GetName()
			{
				return Name;
			}

			public bool IsAlive()
			{
				return HP > 0;
			}

			public virtual void Attack(Character character)
			{
				if (IsAlive() == false)
					return;

				if (character.IsAlive() == false)
					return;

                Console.WriteLine($"{Name}이 {ATk}만큼 {character.Name}에게 공격합니다.");
                // 타겟(상대방)의 체력을 내 공격력 만큼 감소시킨다.
                character.HP -= ATk;

				character.PrintCurrentHP();

				if(character.HP <= 0)
				{
                    Console.WriteLine($"{character.Name}이 죽었습니다.");
                }
			}

			public virtual void PrintCurrentHP() 
			{

			}
		}

		class Player : Character 
		{
			private float criDamage;

            public Player(string name)
            {
                Name = name;
				HP = 100;
				ATk = 10;
				criDamage = 0.2f;
			}

			public override void Attack(Character character) 
			{
				base.Attack(character);
				if (IsAlive() == false)
					return;

				// 타겟 캐릭터가 죽었으면 종료
				if (character.IsAlive() == false)
					return;

				// 랜덤 값으로 추가 치명타 데미지 주는 지에 대한 여부를 결정합니다.
				Random rand = new Random();
				int randomValue = rand.Next(0, 10);
				if (randomValue < 5)
				{
					// 추가 치명타 데미지를 줍니다.
					float cri = ATk * criDamage;
					character.HP -= (int)cri;
					Console.WriteLine("추가 치명타 데미지 " + cri);

					character.PrintCurrentHP();
				}

				if (character.HP <= 0)
				{
					Console.WriteLine($"{character.GetName()}이 죽었습니다.");
				}

			}

			public void PrintName()
			{
				Console.WriteLine("캐릭터 " + Name + " 생성되었습니다.");
			}

			public override void PrintCurrentHP()
			{
				Console.WriteLine(Name + "의 체력은 " + HP + " 입니다.");
			}
		}

		class Goblin : Character
		{
            public Goblin()
            {
				Name = "Goblin";
				HP = 50;
				ATk = 5;

                Console.WriteLine("야생의 고블린 출현했습니다.");
            }

			public override void PrintCurrentHP()
			{
				Console.WriteLine("고블린의 체력은 " + HP + " 입니다.");
			}
        }

		static void Main(string[] args)
		{
			Player player = new Player("Blade");
			player.PrintName();

			Goblin goblin = new Goblin();

            Console.WriteLine("\n");

            player.Attack(goblin);
			goblin.Attack(player);

			Console.WriteLine("\n");

			player.Attack(goblin);
			goblin.Attack(player);

			Console.WriteLine("\n");

			player.Attack(goblin);
			goblin.Attack(player);

			Console.WriteLine("\n");

			player.Attack(goblin);
			goblin.Attack(player);

			Console.WriteLine("\n");

			player.Attack(goblin);
			goblin.Attack(player);
		}
	}
}
