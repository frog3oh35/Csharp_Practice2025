using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Class1
{

   /* 예제 5-6
    class Product
    {
        public string name;
        public int price;
    }
    static void Main(string[] args)
    {

        Product product = new Product();

        product.name = "감자";
        product.price = 2000;

        Console.WriteLine(product.name + " : " + product.price + "원") ;
      */
        
        
        // 예제 실행 (주석 풀어서 실행할 것)
        // Example4();
        // Example4_();
        // Example4_1();
        // Example4_2();
        // Example4_3();
        // Example4_4();
        // Example4_5();
        // Example4_6();
        // Example4_7();
        // Example4_8();
        // Example4_9();
        // Example4_10();

        //Example5_5();
    }

 


    /*20250410
    static void Example5_1()
    {
        Random random = new Random();
        Console.WriteLine(random.Next(10, 100));
        Console.WriteLine(random.Next(10, 100));
        Console.WriteLine(random.Next(10, 100));
        Console.WriteLine(random.Next(10, 100));
        Console.WriteLine(random.Next(10, 100));
    }

    static void Example5_2()
    {
        Random random = new Random();
        Console.WriteLine(random.NextDouble());
        Console.WriteLine(random.NextDouble());
        Console.WriteLine(random.NextDouble());
        Console.WriteLine(random.NextDouble());

    }

    static void Example5_3()
    {
        List<int> list = new List<int>();

        //리스트에 요소 추가
        list.Add(52);
        list.Add(273);
        list.Add(32);
        list.Add(64);

        ///반복 수행
        foreach (var item in list)
        {
            Console.WriteLine("count: " + list.Count + "\titem: " + item);
        }

    }
    
    static void Example5_4()
    {
        List<int> list = new List<int>() { 52, 273, 32, 64 };

        list.Remove(52);

        foreach(var item in list)
        {
            Console.WriteLine("Count: " + list.Count + "\titem: " + item);
        }
    }

    static void Example5_5()
    {
        Console.WriteLine(Math.Abs(-52273));
        Console.WriteLine(Math.Ceiling(52.273));
        Console.WriteLine(Math.Floor(52.273));
        Console.WriteLine(Math.Max(52, 273));
        Console.WriteLine(Math.Min(52, 273));
        Console.WriteLine(Math.Round(52.273));

    }

*/ // 20250410 



    /*
     * 20250403
    static void Example4()
    {
        int[] intArray = { 52, 273, 32, 65, 103 }; 

        intArray[0] = 0;

        Console.WriteLine(intArray[0]);
        Console.WriteLine(intArray[1]);
        Console.WriteLine(intArray[2]);
        Console.WriteLine(intArray[3]);
    }

    static void Example4_()
    {
        int[] intArray = new int[100];
        Console.WriteLine(intArray[0]);
        Console.WriteLine(intArray[99]);
    }
    static void Example4_1()
    {
        int i = 0;
        int[] intArray = { 52, 263, 32, 65, 103 };

        while (i < intArray.Length)
        {
            Console.WriteLine(i + "번째 출력 : " + intArray[i]);
            i++;
        }
    }

    static void Example4_2()
    {
        int output = 0;

        for (int i = 0; i <= 100; i++)
        {
            output += i;
        }

        Console.WriteLine(output);
    }

    static void Example4_3()
    {
        string input;
        do
        {
            Console.Write("입력(exit을 입력하면 종료): ");
            input = Console.ReadLine();
        } while (input != "exit");
    }

    static void Example4_4()
    {
        int output = 1;

        for (int i = 1; i <= 5; i++)
        {
            output *= i;
        }

        Console.WriteLine(output);
    }

    static void Example4_5()
    {
        for (int i = '가'; i <= '힣'; i++)
        {
            Console.WriteLine((char)i);
        }
    }

    static void Example4_6()
    {
        int[] intArray = { 1, 2, 3, 4, 5, 6 };

        for (int i = intArray.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(intArray[i]);
        }
    }

    static void Example4_7()
    {
        string[] array = { "사과", "배", "포도", "딸기", "바나나" };

        foreach (string item in array)
        {
            Console.WriteLine(item);
        }
    }

    static void Example4_8()
    {
        string[] array = { "사과", "배", "포도", "딸기", "바나나" };

        foreach(var item in array)
        {
            Console.WriteLine(item);
        }
    }

    static void Example4_9()
    {
        while (true)
        {
            Console.WriteLine("숫자를 입력해주세요(짝수를 입력하면 종료): ");
            int input = int.Parse(Console.ReadLine());
            if (input % 2 == 0)
            {
                break;
            }
        }
    }

    static void Example4_10()
    {
        for (int i = 1; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }
    */