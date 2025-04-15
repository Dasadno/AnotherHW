using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Manager : ISalary
    {
        public string FullName { get; set; }
        public int WorkingDays { get; set; }

        public double CalculateSalary()
        {
            return WorkingDays * 1000;
        }
    }
}
