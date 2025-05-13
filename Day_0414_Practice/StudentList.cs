using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_0414_practice
{
    internal class Student
    {
        public string name;
        public int grade;

        public Student(string name, int grade)
        {
            this.name = name;
            this.grade = grade;
        }

        public void Print()
        {
            Console.WriteLine($"{name} 학생은 {grade}학년입니다.");
        }
    }
}
