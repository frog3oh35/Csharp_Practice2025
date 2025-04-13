using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_practice
{
    internal class Favorite
    {
        public static void Run()
        {
            List<string> fruits = new List<string>();

            Console.WriteLine("좋아하는 과일 3개를 입력하세요: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"과일 {i + 1}: ");
                fruits.Add(Console.ReadLine());
            }

            bool foundApple = false;

            foreach (string fruit in fruits)
            {
                if (fruit.Contains("사과"))
                {
                    if (!foundApple)
                    {
                        Console.WriteLine("\n'사과'를 좋아하시네요!");
                        foundApple = true;
                    }
                    Console.WriteLine($"-> 입력한 과일: {fruit}");
                }

                if (!foundApple)
                {
                    Console.WriteLine("\n사과는 별로이신가봐요!");
                }
            }
        }
    }
}
