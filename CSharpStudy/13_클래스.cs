namespace ConsoleApp1
{
	internal class Program
	{
		// 클래스
		// 객체지향 프로그래밍에 대한 이해
		// 클래스는 객체지향 프로그래밍의 가장 기본이 되는 구조로,
		// 데이터(속성)와 그 데이터를 조작하는 메서드(함수)를 하나의 
		// 단위로 묶어서 관리합니다.
		
		// 클래스의 구성 요소
		// 속성 : 데이터들
		// 메서드 : 함수

		// 클래스의 장점
		// 1, 코드 재상용성
		// 2, 구조화 및 캡슐화
		// 3, 유지 보수성

		class Car
		{
			// Car 클래스의 속성 : 자동차 모델명을 저장
			public string modelName;

			// Car 클래스의 메서드 : 자동차가 주행 중임을 콘솔에 출력한다.
			public void Drive()
			{
                Console.WriteLine(modelName + " is drive");
            }
		}

		class Bike
		{
			// Car 클래스의 속성 : 자동차 모델명을 저장
			public string modelName;

			// Car 클래스의 메서드 : 자동차가 주행 중임을 콘솔에 출력한다.
			public void Drive()
			{
				Console.WriteLine(modelName + " is drive");
			}
		}

		static int Add(ref int a ,int b)
		{
			int result = a + b;
			a += b;
			return result;
		}


		static void Main(string[] args)
		{
			// 복사 : 값 타입 => int, float, string
			int a = 5;
			int b = a;
			b = 20;
			Console.WriteLine(a);

			Add(ref a, b);
			Console.WriteLine(a);

			// 참조 : 
			// Car 클래스의 인스턴스 생성
			// 인스턴스 : 객체
			Car car1 = new Car();
			// 객체의 속성에 값을 할당
			car1.modelName = "Volvo";
			// 객체의 메소드(함수)를 호출
			car1.Drive();

			Car car2 = car1;
			//Car car2 = new Car();
			// 객체의 속성에 값을 할당
			car2.modelName = "Ford";
			// 객체의 메소드(함수)를 호출
			car2.Drive();


			car1.Drive();
			car2.Drive();
		}

        // 클래스 
        // 인스턴스 : 객체
        //
        // 생성자와 소멸자
        // 생성자 : 클래스의 인스턴스가 생성될 때 자동으로 호출되는 특별한 메서드(함수)입니다.
        // 소멸자 : 객체가 더 이상 필요 없어져서 메모리에서 해제될 때 자동으로 호출되는 메서드입니다.
        // 가비지 컬렉터 => 메모리를 자동으로 해지시켜주기에 소멸자는 호출이 안된다.
        // 
        // 클래스의 특징(객체지향 프로그래밍 이해하기)
        // 1, 상속성 : 한 클래스의 속성과 메서드를 다른 클래스가 상속받아서 사용 할 수 있게 하는 매커니즘입니다.
        //		부모 클래스(슈퍼 클래스) : 상속을 해주는 클래스
        //		자식 클래스(서브 클래스) : 상속을 받는 클래스
        // 2, 은닉성 : 
        // 3, 다형성 : 

        // 생성자와 소멸자
        //class Car
        //{
        //	// 속성(변수)
        //	public string Model;

        //	// Car 클래스 생성자
        //	// 기본 생성자 => 호출 안해도 된다. => C# 자동적으로 알아서 메모리에 할당 시켜준다.
        //	public Car()
        //	{
        //              Console.WriteLine("Car 클래스의 생성자가 호출되었습니다");
        //          }

        //	public Car(string model)
        //	{
        //		Model = model;
        //		Console.WriteLine("Car 클래스의 모델 이름은 " + Model + "입니다.");
        //          }

        //	// Car 클래스 소멸자
        //	// 가비지 컬렉터 => 메모리를 자동으로 해지시켜주기에 소멸자는 호출이 안된다.
        //	~Car()
        //	{
        //		Console.WriteLine("Car 클래스의 소멸자가 호출되었습니다");
        //	}
        //}

        // 상속성 
        class Vehicle // 탈것 : 부모 클래스
        {
            public string BrandName;

            public void Drive()
            {
                Console.WriteLine(BrandName + " 이 이동하고 있습니다.");
            }

            public Vehicle()
            {
                Console.WriteLine("Vehicle 클래스의 생성자가 호출되었습니다");
            }
        }

        // 자식 클래스
        class Car : Vehicle
        {
            public string ModelName;

            public Car()
            {
                Console.WriteLine("Car 클래스의 생성자가 호출되었습니다");
            }
        }

        // 자식 클래스
        class Bike : Vehicle
        {
            public string ModelName;

            public Bike()
            {
                Console.WriteLine("Bike 클래스의 생성자가 호출되었습니다");
            }
        }

        static void Main(string[] args)
        {
            Car car = new Car();
            car.BrandName = "Ford";
            car.ModelName = "Mustang";
            car.Drive();

            Bike bike = new Bike();
            bike.BrandName = "Volvo";
            bike.ModelName = "Volvo";
            bike.Drive();
        }



        // 상속성 
        class Character // 탈것 : 부모 클래스
        {
            public string nickName;
            public int HP;
            public int MP;

            // 이동 속도
            private float moveSpeed;

            // 공격력
            protected int Attack;

            // 은닉성 : 클래스 내부 구현을 숨기고 외부에서는 접근 할 수 없도록 막는 것
            // private : 외부에서 접근이 아예 안됩니다.
            // protected : 외부에서 접근이 안되지만
            //		상속 받은 자식 계층에서는 접근이 가능합니다.
            // public : 외부에서 언제든지 접근이 가능합니다.

            public Character()
            {
                Console.WriteLine("Character 클래스의 생성자가 호출되었습니다");
            }
        }

        // 자식 클래스
        class Knight : Character
        {

            public Knight()
            {
                Console.WriteLine("Knight 클래스의 생성자가 호출되었습니다");
            }
        }

        // 자식 클래스
        class Mage : Character
        {
            public Mage()
            {
                Console.WriteLine("Mage 클래스의 생성자가 호출되었습니다");
            }

            public void ChangeAttack(int newAttack)
            {
                Attack = newAttack;
            }
        }

        static void Main(string[] args)
        {
            Mage mage = new Mage();
            mage.HP = 100;
            //Mage에 데미지를 준다.
            mage.HP -= 10;

            mage.moveSpeed = 4.0f;
            mage.Attack = 3;
        }


        // 상속성 
        class Character // 탈것 : 부모 클래스
        {
            public string nickName;
            public int HP;
            public int MP;

            // 이동 속도
            private float moveSpeed;

            // 공격력
            protected int attck;

            // 은닉성 : 클래스 내부 구현을 숨기고 외부에서는 접근 할 수 없도록 막는 것
            // private : 외부에서 접근이 아예 안됩니다.
            // protected : 외부에서 접근이 안되지만
            //		상속 받은 자식 계층에서는 접근이 가능합니다.
            // public : 외부에서 언제든지 접근이 가능합니다.

            // 다형성 : 메서드 오버라이딩을 통해서 구현합니다.
            // 메서드 오버라이딩 : 상속 관계에 있는 클래스에서 부모 클래스에 정의된 함수를
            //					  자식 클래스에서 재정의하는 것을 말합니다.
            // virtual  : 
            // override : 
            public virtual void Attack()
            {
                Console.WriteLine("Character Attack!");
            }
        }

        // 자식 클래스
        class Knight : Character
        {
            public override void Attack()
            {
                base.Attack();
                Console.WriteLine("Knight Attack");
            }
        }

        // 자식 클래스
        class Mage : Character
        {
            public void ChangeAttack(int newAttack)
            {
                attck = newAttack;
            }
            public override void Attack()
            {
                Console.WriteLine("Mage Attack");
            }
        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.Attack();

            Mage mage = new Mage();
            mage.Attack();
        }
    }
}
