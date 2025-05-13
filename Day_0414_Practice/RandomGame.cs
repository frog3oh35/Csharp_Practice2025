using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_0414_practice
{
    internal class RandomGame
    {
        private Random random = new Random();

        public void Play()
        {
            int number = random.Next(1, 6);
            Console.Write("1~5 중 숫자 맞히기! ▶ ");
            int guess = int.Parse(Console.ReadLine());

            if (guess == number)
            {
                Console.WriteLine("정답입니다!");
            }
            else
            {
                Console.WriteLine($"아쉽네요~ 정답은 {number}였어요.");
            }
        }
    }
}
