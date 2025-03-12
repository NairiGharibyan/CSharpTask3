using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollSystem
{
    public class Employee
    {
        string Name;
        string Position;
        double SalaryPerHour;
        double HoursWorked;

        public Employee(string name, string pos, double slrPH, double HrsWrkd) {
            Name = name;
            Position = pos;
            SalaryPerHour = slrPH;
            HoursWorked = HrsWrkd;
        }


        public double CalcSalary() { 
            if (HoursWorked < 41) {
                return SalaryPerHour * HoursWorked;    
            }
            double regular_pay = 40 * SalaryPerHour;
            double overtime_hrs = HoursWorked - 40;
            double overtime_rate = SalaryPerHour * 1.5;
            double overtime_pay = overtime_rate * overtime_hrs; 

            return regular_pay + overtime_pay;


            
        }

        public void Display() {
            double salary = CalcSalary();
            Console.WriteLine($"Employee Name: {Name}, Position: {Position}, SlrPerHour: {SalaryPerHour}$, HrsWorked: {HoursWorked}");
            Console.WriteLine($"Salary for {Name}: {salary}$");
        }


    }
}
