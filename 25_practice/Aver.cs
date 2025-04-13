
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _25_practice;

namespace _25_practice
{
    class Aver
    {
        public static void Run()
        {
            int[] scores = { 85, 92, 78, 90, 88 };
            int sum = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }

            double average = (double)sum / scores.Length;
            Console.WriteLine($"평균 점수는 {average}점입니다.");
        }
    }
}
