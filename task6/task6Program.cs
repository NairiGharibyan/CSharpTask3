using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee("Gayan", "Counter", 30, 30));
            list.Add(new Employee("Ruzan", "Cleaner", 10, 60));
            list.Add(new Employee("Melan", "Manager", 70, 45));

            foreach (Employee emp in list) {
                emp.Display();
            }

            Console.Read();
        }
    }
}
