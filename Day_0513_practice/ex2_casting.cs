using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_0513_practice
{
    class Animal
    {
        public string Name;
    }

    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("냐~");
        }
    }
    internal class ex2_casting
    {
        static void Main()
        {
            Animal animal = new Cat();
            Cat cat = animal as Cat;

            if (cat != null)
            {
                cat.Meow();
            }
            else
            {
                Console.WriteLine("형변환 실패");
            }
        }
    }
}