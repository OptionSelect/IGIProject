using System;

namespace IGIProject
{
    public class Sniper : Soldier, ISniper
    {
        public Sniper() : base(new Rifle())
        {
            
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