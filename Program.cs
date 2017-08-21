using System;
using System.Linq;
using System.Collections.Generic;

namespace IGIProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var Speedy = new Pilot();
            var Snipey = new Sniper();
            var Healy = new Medic();

            var Army = new List<Soldier>();
            Army.Add(Speedy);
            Army.Add(Snipey);
            Army.Add(Healy);

            Army.ForEach(fighter => fighter.Attack());
            Army.ForEach(fighter => fighter.Speak());
            //Army.ForEach(fighter => Console.WriteLine($"This is my weapon {Weapon}.");
        }
    }
}
