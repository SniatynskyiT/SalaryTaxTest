using SalaryTax.Concrete;
using SalaryTax.Interfaces;
using System;

namespace SalaryTax
{
    class Program
    {
        static void Main(string[] args)
        {
            double basicSalary;
            double currentSalary;

            Console.Write("Basic Salary: ");
            bool resultBasicSalary = Double.TryParse(Console.ReadLine(), out basicSalary);
            Console.Write("Current Salary: ");
            bool resultCurrentSalary = Double.TryParse(Console.ReadLine(), out currentSalary);

            Console.WriteLine("-------------------------------------------------");

            if(resultBasicSalary && resultCurrentSalary)
            {
                ITaxFactory taxFactory = new TaxFactory(basicSalary >= 0 ? basicSalary : 0, currentSalary >= 0 ? currentSalary : 0);
                ITax tax = taxFactory.CreateTax();
                Console.WriteLine(tax);
            }
            else
            {
                Console.WriteLine("Couldn't parse to Double");
            }

            Console.ReadKey();

        }
    }
}
