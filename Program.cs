using System;
using System.Linq;
using System.Collections.Generic;

namespace IGIProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var Speedy = new Pilot("Speedy McSpeederson", "Sgt", 1234);
            var Snipey = new Sniper("Snipey McSniperton", "Master Chief", 1);
            var Healy = new Medic("Healy McHealerone", "Private", 69);

            var Army = new List<Soldier>();
            Army.Add(Speedy);
            Army.Add(Snipey);
            Army.Add(Healy);

            Console.WriteLine($"Pilot: {Speedy.Name}. Rank: {Speedy.Rank}. Serial#: {Speedy.SerialNumber}. Weapon: {Speedy.Weapon}");
            Console.WriteLine($"Sniper: {Snipey.Name}. Rank: {Snipey.Rank}. Serial#: {Snipey.SerialNumber}. Weapon: {Snipey.Weapon});
            Console.WriteLine($"Medic: {Healy.Name}. Rank: {Healy.Rank}. Serial#: {Healy.SerialNumber}. Weapon: {Healy.Weapon}");
            
            Army.ForEach(fighter => fighter.Attack());
            Army.ForEach(fighter => fighter.Speak());
            //Army.ForEach(fighter => Console.WriteLine($"This is my weapon {Weapon}.");
        }
    }
}
