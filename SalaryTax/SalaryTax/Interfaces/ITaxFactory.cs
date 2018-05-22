using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryTax.Interfaces
{
    public interface ITaxFactory
    {
        ITax CreateTax();
    }
}
