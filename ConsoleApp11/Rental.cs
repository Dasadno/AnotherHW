using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Rental<T> where T : struct, ITransport
    {
        public string CustomerName { get; set; }
        public T Vehicle { get; set; }
        public int RentalTime { get; set; }

        public string GetRentalInfo()
        {
            return $"{CustomerName} Rent: {Vehicle.Type} ({Vehicle.GetType().Name}) for {Vehicle.RentalCostPerMinute} per rubles minute";
        }

        public double CalculateTotalCost()
        {
            return RentalTime * Vehicle.RentalCostPerMinute;
        }
    }
}
