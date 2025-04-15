using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public interface ITax
    {
        string ProductName { get; set; }
        double Price { get; set; }
        double AddTax();
        static string ClassName => "Tax";
    }
}
