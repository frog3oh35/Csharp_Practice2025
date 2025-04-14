using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_0414_practice
{
    internal class Counter
    {
        //클래스 변수 연습
        public static int totalCount = 0;
        public int myNumber;

        public Counter()
        {
            totalCount++;
            myNumber = totalCount;
        }

        public void Show()
        {
            Console.WriteLine($"이 인스턴스의 번호: {myNumber}");
        }
    }
}
