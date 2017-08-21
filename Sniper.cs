using System;

namespace IGIProject
{
    public class Sniper : Soldier, ISniper
    {
        public Sniper(string name, string rank, int serial) : base(new Rifle())
        {
            Name = name;
            Rank = rank;
            SerialNumber = serial;
        }

        public string Rifle { get; set; }

        public void NumRounds()
        {
            Console.WriteLine("Mags full.");
        }

        public void NumSmokes()
        {
            Console.WriteLine("Smoke 'em if you got em.");
        }

        public override void Speak()
        {
            Console.WriteLine("Boom headshot.");
        }
    }
}