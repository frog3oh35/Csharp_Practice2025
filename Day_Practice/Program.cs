using Day_0414_practice;
using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace Day_0414_practice
{
    class program
    {
        static void Main()
        {
            /* ★★★ product.cs
            Product p1 = new Product("감자", 2000);
            Product p2 = new Product("고구마", 3000);

            p1.Print();
            p2.Print();
            */



            /* ★★★Counter.cs
            Counter c1 = new Counter();
            Counter c2 = new Counter();
            Counter c3 = new Counter();

            c1.Show();
            c2.Show();
            c3.Show();

            Console.WriteLine($"총 생성된 인스턴스 수: {Counter.totalCount}");
            */



            /* ★★★ StudentList.cs
            List<Student> students = new List<Student>();
            students.Add(new Student("민지", 1));
            students.Add(new Student("철수", 2));
            students.Add(new Student("수진", 3));

            foreach(Student s in students)
            {
                s.Print();
            }             
            */



            /* ★★★ TeamMember.cs 내부 클래스 연습
            Team team = new Team("DevTeam");
            team.AddMember("연하");
            team.AddMember("정훈");             
             */



            /* ★★★ RandomGame.cs
            Team team = new Team("DevTeam");
            team.AddMember("연하");
            team.AddMember("정훈");             
             */


            /*
            RandomGame game = new RandomGame();
            game.Play();
            */

        }
    }
}