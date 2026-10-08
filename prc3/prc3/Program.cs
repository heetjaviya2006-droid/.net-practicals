using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3
{

    class Expense
    {
        public int ExpenseId;
        public string Category;
        public double Amount;
        public string Paymentmode;
        public DateTime ExpenseDate;

        public void AddExpense()
        {
            Console.Write("Enter Expese Id: ");
            ExpenseId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Expese Category: ");
            Category = Console.ReadLine();

            Console.Write("Enter Expese Amount: ");
            Amount = Convert.ToDouble(Console.ReadLine());

            if (Amount < 0)
            {
                throw new Exception("Amount Can't be negative");
            }

            Console.Write("Enter Payment Mode(Cash/Card/UPI):");
            Paymentmode = Console.ReadLine();

            ExpenseDate = DateTime.Now;

        }

        public void DisplayExpense()
        {
            Console.Write("\n\nExpese Id: " + ExpenseId);
            Console.Write("\nExpese Category: " + Category);
            Console.Write("\nExpese Amount: " + Amount);
            Console.Write("\nPayment Mode(Cash/Card/UPI):" + Paymentmode);
            Console.WriteLine("\nPayment Date:" + ExpenseDate);
            ;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int choise;
            List<Expense> exp = new List<Expense>();
            double total = 0;

            while (true)
            {
                Console.WriteLine("\n\nEeter your Choise:");
                Console.WriteLine("1. Add Expense     :");
                Console.WriteLine("2. Display Expense :");
                Console.WriteLine("3. Total Expense   :");
                Console.WriteLine("4. Exit:");
                choise = Convert.ToInt32(Console.ReadLine());

                try
                {
                    if (choise == 1)
                    {
                        Expense e1 = new Expense();
                        e1.AddExpense();
                        Console.WriteLine("Success");
                        exp.Add(e1);
                    }
                    else if (choise == 2)
                    {
                        foreach (Expense e in exp)
                        {

                            e.DisplayExpense();
                        }

                    }
                    else if (choise == 3)
                    {
                        foreach (Expense e in exp)
                        {
                            total += e.Amount;

                        }
                        Console.WriteLine("\n\nTotal Expense:" + total);

                    }
                    else if (choise == 4)
                    {
                        return;
                    }
                    else { Console.WriteLine("You enter Wrong Choise"); }

                }
                catch (Exception e)
                {
                    {
                        Console.WriteLine(e);
                    }
                }

            }
        }
    }
}