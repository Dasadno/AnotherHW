using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public struct Employee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string Position { get; set; }
        public int YearOfHiring { get; set; }

        public string Info => $"{LastName} {FirstName} {Patronymic}, Должность: {Position}, Год принятия: {YearOfHiring}";

        public int GetExperience(int currentYear)
        {
            return currentYear - YearOfHiring;
        }
    }
}
