using System;
using System.Linq;
using System.Collections.Generic;

namespace IGIProject
{
    public abstract class Soldier : IAttacker
    {
        public string Name { get; set; }
        public string Rank { get; set; }
        public int SerialNumber { get; set; }

        public IWeapon Weapon { get; set; }

        public Soldier(IWeapon weapon)
        {
            this.Weapon = weapon;
        }

        public void Attack()
        {
            this.Weapon.DoDamage();
        }

        public string Sleep()
        {
            return "Zzz...";
        }
        public string Eat()
        {
            return "Yum yum!";
        }
        public string March()
        {
            return "Stomp stomp stomp..."
        }
        public abstract void Speak();

    }
}