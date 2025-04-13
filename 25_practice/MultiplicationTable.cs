using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_practice
{
    internal class MultiplicationTable
    {
        public static void Run()
        {
            for (int dan = 2; dan <=9; dan++)
            {
                for(int i = 1; i<=9; i++)
                {
                    Console.Write($"{dan} x {i} = {dan * i} ");
                }
                Console.WriteLine(); //줄바꿈
            }
        }
    }
}
