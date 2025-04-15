using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class LuxuryItems : ITax
    {
        public string ProductName { get; set; }
        public double Price { get; set; }

        public double AddTax()
        {
            return Price * 1.2;
        }

        public static string ClassName => "Luxury Items";
    }
}
