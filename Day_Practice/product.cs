using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_0414_practice
{
    internal class Product
    {
        public string name;
        public int price;

        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public void Print()
        {
            Console.WriteLine($"상품 이름: {name}, 가격 {price}원");
        }
    }
}
