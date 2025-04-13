using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_practice
{
    internal class SerchName
    {
        public static void Run()
        {
            string[] names = { "지민", "철수", "영희", "민수" };

            Console.Write("찾고 싶은 이름을 입력하세요: ");
            string input = Console.ReadLine();

            bool found = false;
            foreach (string name in names)
            {
                if (name == input)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine($"{input}은 명단에 있습니다.");
            else
                Console.WriteLine($"{input}은 명단에 없습니다.");
        }
    }
}
