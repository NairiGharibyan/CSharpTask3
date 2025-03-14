using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMNG
{
    internal class Teacher
    {
        public string Name;
        public string Subject;
        public int YearsOfExp;

        public Teacher(string name, string subject, int yearsOfExp)
        {
            Name = name;
            Subject = subject;
            YearsOfExp = yearsOfExp;
        }
    }
}

