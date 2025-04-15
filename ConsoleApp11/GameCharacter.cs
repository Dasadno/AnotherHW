using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class GameCharacter<T> where T : struct, IWeapon
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public T Weapon { get; set; }
        public int Strength { get; set; }

        public string GetCharacterInfo()
        {
            return $"{Name} ({Race}) Weapon: {Weapon.Type}, Power of weapon: {Weapon.Power}, Special ability: {Weapon.SpecialAbility}.";
        }

        public int CalculateTotalStrength()
        {
            return Strength + Weapon.Power;
        }
    }
}
