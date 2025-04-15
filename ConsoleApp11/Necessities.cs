using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Necessities : ITax
    {
        public string ProductName { get; set; }
        public double Price { get; set; }

        public double AddTax()
        {
            return Price * 1.005;
        }

        public static string ClassName => "item that must used";
    }
}
