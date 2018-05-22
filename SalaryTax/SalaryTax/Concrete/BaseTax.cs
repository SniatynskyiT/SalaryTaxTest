using SalaryTax.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryTax.Concrete
{
    public class BaseTax : ITax
    {
        protected double _basicSalary;
        protected double _currentSalary;

        public BaseTax(double basicSalary, double currentSalary)
        {
            _basicSalary = basicSalary;
            _currentSalary = currentSalary;
        }
        public virtual double GetTax()
        {
            return 0;
        }

        public override string ToString()
        {
            return "Basic Salary: " + _basicSalary + "\nCurrent Salary(Brutto): " + _currentSalary + "\nTaxes to pay: " + GetTax()
                + "\nCurrent Salary(Netto): " + (_currentSalary - GetTax());
        }
    }
}
