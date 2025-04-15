using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class ConsoleOutput : IConsolePrint
    {
        private readonly ITax _taxProduct;

        public ConsoleOutput(ITax taxProduct)
        {
            _taxProduct = taxProduct;
        }

        public void Print()
        {
            Console.WriteLine($"{_taxProduct.GetType().Name}: {_taxProduct.ProductName}, Цена без налога: {_taxProduct.Price}, Цена с налогом: {_taxProduct.AddTax()}");
        }
    }
}
