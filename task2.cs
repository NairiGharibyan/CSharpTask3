using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask
{
    public class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }


        public Student(string name, int age, int grade)
        {
            Name = name;
            Age = age;
            
            Grade = grade;
        }

        public void Display() {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("Michale", 23, 10);
            Student st2 = new Student("Arnold", 18, 5);
            Student st3 = new Student("fredo", 30, 8);
            Student st4 = new Student("Derenic", 40, 0);
            Student st5 = new Student("Alberto", 13, 1);

            Student[] students = { st1, st2, st3, st4, st5 };
            foreach (Student student in students) {
                student.Display();
            }
            Console.ReadLine();

        }
    }
}
