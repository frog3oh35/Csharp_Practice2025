using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Day_0414_practice
{
    class Team
    {
        private string teamName;

        public Team(string name)
        {
            teamName = name;
        }

        public void AddMember(string memberName)
        {
            Member m = new Member(memberName);
            m.Print();
        }

        private class Member
        {
            private string name;

            public Member(string name)
            {
                this.name = name;
            }
            
            public void Print()
            {
                Console.WriteLine($"팀원 이름: {name}");
            }
        }

    }
}
