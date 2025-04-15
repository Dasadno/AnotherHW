using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public struct Scooter : ITransport
    {
        public string Model { get; set; }
        public int Year { get; set; }

        public string Type => "scooter";
        public double RentalCostPerMinute => 5.0;
    }
}
