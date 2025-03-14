using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMNG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student("Jhon", 18, 9);
            Student std2 = new Student("Linza", 17, 10);
            Student std3 = new Student("Ashot", 20, 7);

            Teacher tch1 = new Teacher("Sergey", "Math", 1);
            Teacher tch2 = new Teacher("Torgom", "English", 3);

            Student []students = new Student[] { std1, std2, std3 };
            Teacher[] teachers = new Teacher[] { tch1, tch2 };
            
            School school = new School(students, teachers);
            school.Show();

            Console.Read();
        }
    }
}

