﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public interface ITransport
    {
        string Type { get; }
        double RentalCostPerMinute { get; }
    }
}
