using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_practice
{
    internal class listWrite
    {
        public static void Run()
        {
            List<int> scores = new List<int> { 95, 60, 82, 100, 76 };

            Console.WriteLine("90점 이상인 점수들:");
            foreach (int score in scores)
            {
                if (score >= 90)
                {
                    Console.WriteLine(score);
                }
            }
        }
    } 
}
