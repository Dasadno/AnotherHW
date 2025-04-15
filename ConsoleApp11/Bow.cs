using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public struct Bow : IWeapon
    {
        public int Range { get; set; }
        public int Accuracy { get; set; }

        public string Type => "Лук";
        public int Power => 30;
        public string SpecialAbility => $"Range: {Range}, Accuracy: {Accuracy}";
    }
}
