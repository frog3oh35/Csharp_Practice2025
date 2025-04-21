using school_project_0417;
using System;
using System.Net.Http.Headers;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;


internal class Test
{
    public int Power(int x)
    {
        return x * x;
    }
}


internal class Test2
{
    public int Multi(int x, int y)
    {
        return x * y;
    }
}

class Test3
{
    public void Print()
    {
        Console.WriteLine("Print() 메서드가 호출되었습니다.");
    }
}

class Test4
{
    public int Sum(int min, int max)
    {
        int output = 0;
        for (int i = min; i <= max; i++)
        {
            output += i;
        }
        return output;
    }
}

class Test5
{
    public int Multiply(int min, int max)
    {
        int output = 1;
        for (int i = min; i <=max; i++)
        {
            output *= 1;
        }
        return output;
    }
}

class MyMath
{
    public static int Abs(int input)
    {
        if (input < 0)
        {
            return -input;
        }
        else {
            return input;
        }
    }

    //이하 오버로딩. 오버로딩 중요
    public static double Abs(double input)
    {
        if (input < 0)
        {
            return -input;
        }
        else
        {
            return input;
        }
    }

    public static long Abs(long input)
    {
        if (input < 0)
        {
            return -input;
        }
        else
        {
            return input;
        }
    }
}



namespace school_practice_0417
{
    //chapter 06 method
    class Program
    {
        static void Main(string[] args)
        {
            /* Test 1
            Test test = new Test();
            Console.WriteLine(test.Power(10));
            Console.WriteLine(test.Power(20));
            */

            /* test 2
            Test2 test = new Test2();
            Console.WriteLine(test.Multi(52, 263));
            Console.WriteLine(test.Multi(103, 32));
            */

            /* test 3
            Test3 test = new Test3();
            test.Print();
            test.Print();
            test.Print();
             */

            /* test 4
            Test4 test = new Test4();
            Console.WriteLine(test.Sum(1, 100));             
             */

            /* test 5
            Test5 test = new Test5();
            Console.WriteLine(test.Multiply(1, 10));
            */

            /* MyMath
            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-273));

            double
            Console.WriteLine(MyMath.Abs(52.263));
            Console.WriteLine(MyMath.Abs(-32.103));

            long
            Console.WriteLine(MyMath.Abs(23424323234));
            Console.WriteLine(MyMath.Abs(-23424323234));
            */

            /* Product 이부분도 중요
            Product productA = new Product("감자", 2000);
            Product productB = new Product("고구마", 3000);

            Console.WriteLine(productA.id + ":" + productA.name);
            Console.WriteLine(productB.id + ":" + productB.name);
            Console.WriteLine(Product.counter + "개 생성되었습니다.");
             */

            /* Product2
            Product2 product = new Product2("과자", 1000);
            */


            //get set 활용도 중요
            Box box = new Box(-10, -20);

            box.Width = -200;
            box.Height = -100;




        }
    }
}
