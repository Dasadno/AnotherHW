using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Accountant
    {
        public double CalculateIncomeTax(ISalary employee)
        {
            return employee.CalculateSalary() * 0.13;
        }
    }
}
