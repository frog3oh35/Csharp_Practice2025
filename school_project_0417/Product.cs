using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_practice_0417
{
    internal class Product
    {
        public static int counter = 0;
        public int id;
        public string name;
        public int price;

        public Product(string name, int price)
        {
            Product.counter = counter + 1;
            this.id = counter;
            this.name = name;
            this.price = price;
        }
    }
}
