using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_project_0417
{
    internal class Product2
    {
        public string name;
        public int price;

        public Product2(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        ~Product2()
        {
            Console.WriteLine(this.name + "의 소멸자 호출");
        }
    }
}
