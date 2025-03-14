using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMNG
{
    internal class School
    {
        Student[] students;
        Teacher[] teachers;

        public School(Student[] students, Teacher[] teachers)
        {
            this.students = students;
            this.teachers = teachers;
        }

        public void Show()
        {
            foreach (Student student in students)
            {
                if (student.Grade > 7)
                {
                    Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
                }
            }
            foreach (Teacher teacher in teachers) {
                if (teacher.YearsOfExp < 2) {
                    Console.WriteLine($"Name: {teacher.Name}, Subject: {teacher.Subject}, WorkExp: {teacher.YearsOfExp} Years");
                }
            }
        }
    }
}

