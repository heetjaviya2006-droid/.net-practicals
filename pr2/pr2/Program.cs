using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical2
{

    class Employee
    {
        public Employee()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Employee Details");
            Console.WriteLine("----------------");
        }

        public int EmployeeId;
        public string EmployeeName;
        public double EmployeeSalary;

        public void AcceptDetails()
        {
            Console.Write("Enter Employee Id: ");
            EmployeeId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee name: ");
            EmployeeName = Console.ReadLine();

            Console.Write("Enter Employee Salary: ");
            EmployeeSalary = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            Console.Write("\nEmployee Id      : " + EmployeeId);
            Console.Write("\nEmployee name    : " + EmployeeName);
            Console.Write("\nEmployee Salary  : " + EmployeeSalary);

        }


        public virtual void calculateSalary()
        {
            Console.WriteLine("Print Salary");
        }
    }

    class FulltimeEmployee : Employee
    {
        public override void calculateSalary()
        {
            double DA = (EmployeeSalary * 0.20);
            double HRA = (EmployeeSalary * 0.10);

            double finalSalary = EmployeeSalary + DA + HRA;

            Console.Write("\nFull timeEmployee Final Salary: " + finalSalary);

        }


    }

    class ParttimeEmployee : Employee
    {
        public override void calculateSalary()
        {
            double finalSalary = EmployeeSalary;
            Console.Write("\nParttime Employee Final Salary: " + finalSalary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Registration");

            Console.WriteLine("Enter Empoyee Type:");
            Console.WriteLine("1 for Fulltime Employee");
            Console.WriteLine("2 for Parttime Employee");
            int choice = Convert.ToInt32(Console.ReadLine());

            Employee employee = null;

            if (choice == 1)
            {
                employee = new FulltimeEmployee();
            }
            else if (choice == 2)
            {
                employee = new ParttimeEmployee();
            }
            else
            {
                Console.WriteLine("You enter wrong Choice");
                return;
            }

            employee.AcceptDetails();
            employee.DisplayDetails();
            employee.calculateSalary();



        }
    }
}