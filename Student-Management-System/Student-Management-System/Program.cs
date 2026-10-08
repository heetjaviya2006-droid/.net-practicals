using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practical1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student Student1 = new student();

            Student1.CaptureStudentDetails();
            Student1.calculateScholership();
            Student1.printStudentDetails();
        }
    }

    class student
    {
        public int AdmissionNO;
        public string Name;
        public string Department;
        public int Semester;

        private double fee;
        private bool isEligibel;

        private double scholershipRate = 0.10;
        public student()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("-----------Student Details-------------");
            Console.WriteLine("---------------------------------------");

            Department = "CE";
            Semester = 5;
            Console.WriteLine("Student object created....");

        }

        public void CaptureStudentDetails()
        {
            Console.Write("Enter Student Admission No  :");
            AdmissionNO = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student name          :");
            Name = Console.ReadLine();

            Console.Write("Enter Student department    :");
            Department = Console.ReadLine();

            Console.Write("Enter Student Semester      :");
            Semester = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Fee      :");
            fee = Convert.ToDouble(Console.ReadLine());
        }

        public void calculateScholership()
        {
            if (fee <= 50000)
            {
                isEligibel = true;

            }
            else
            {
                isEligibel = false;
            }
        }

        public void printStudentDetails()
        {
            Console.WriteLine("\n\nStudent Admission No  : " + AdmissionNO);
            Console.WriteLine("Student name              : " + Name);
            Console.WriteLine("Student department        : " + Department);
            Console.WriteLine("Student Semester          : " + Semester);
            Console.WriteLine("Student Fee               : " + fee);
            if (isEligibel)
            {
                Console.WriteLine("Student Scholership      : " + isEligibel);
                fee = fee - (fee * scholershipRate);
                Console.WriteLine("Student Discount fee     : " + fee);
            }
        }
    }


}