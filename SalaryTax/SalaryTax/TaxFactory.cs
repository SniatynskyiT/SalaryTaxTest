using SalaryTax.Concrete;
using SalaryTax.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryTax
{
    public class TaxFactory: ITaxFactory
    {
        private readonly double _basicSalary;

        private readonly double _currentSalary;

        const double _persentKoefOne = 0.17;

        const double _persentKoefTwo = 0.2;

        public TaxFactory(double basicSalary, double currentSalary)
        {
            _basicSalary = basicSalary;
            _currentSalary = currentSalary;
        }

        public ITax CreateTax()
        {
            switch(_currentSalary)
            {
                case var salary when (salary <= _basicSalary):
                    return new BaseTax(_basicSalary, _currentSalary);
                case var salary when (salary <= 5 * _basicSalary):
                    return new FirstTax(_basicSalary, _currentSalary);
                case var salary when (salary <= 10 * _basicSalary):
                    return new SecondTax(_basicSalary, _currentSalary, _persentKoefOne);
                default:
                    return new SecondTax(_basicSalary, _currentSalary, _persentKoefTwo);
            }
                  
        }
    }
}
