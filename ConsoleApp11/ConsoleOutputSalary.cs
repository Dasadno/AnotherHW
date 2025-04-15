using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class ConsoleOutputSalary : IConsolePrint
    {
        private readonly ISalary _employee;

        public ConsoleOutputSalary(ISalary employee)
        {
            _employee = employee;
        }

        public void Print()
        {
            Console.WriteLine($"Full Name: {_employee.FullName}, Working days: {_employee.WorkingDays}, Salary: {_employee.CalculateSalary()}");
        }
    }
}
