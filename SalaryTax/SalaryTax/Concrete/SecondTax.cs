using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryTax.Concrete
{
    public class SecondTax: FirstTax
    {
        private double _fiveBasicSalary;

        private double _percent;
        public SecondTax(double basicSalary, double currentSalary, double percent) : base(basicSalary, currentSalary)
        {
            _fiveBasicSalary = 5 * _basicSalary;
            _percent = percent;
        }
        public override double GetTax()
        {
           return Math.Abs(_currentSalary - _fiveBasicSalary) * _percent;
        }
    }
}
