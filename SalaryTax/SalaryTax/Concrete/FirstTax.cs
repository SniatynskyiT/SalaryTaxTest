using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryTax.Concrete
{
    public class FirstTax: BaseTax
    {
        private double _koef = 0.15;
        public FirstTax(double basicSalary, double currentSalary) : base(basicSalary, currentSalary) { }
        public override double GetTax()
        {
            return _currentSalary * _koef;
        }
    }
}
