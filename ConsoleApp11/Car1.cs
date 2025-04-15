using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public struct Car1
    {
        public string Vin { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public string Info => $"Brand: {Brand}, Model: {Model}, Vehicle year: {Year}, Color: {Color}";

        public string CheckVin(string vin)
        {
            return vin == Vin ? "VIN matches" : "VIN isn't matches";
        }
    }
}
