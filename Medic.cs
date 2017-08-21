using System;

namespace IGIProject
{
    public class Medic : Soldier, IMedic
    {
        public Medic(): base(new MedKit())
        {
            
        }

        public string Medkit { get; set; }

        public void NumAlcohol()
        {
            Console.WriteLine("I got a whole bunch of alcohol for you sickos.");            
        }

        public void NumBandages()
        {
            Console.WriteLine("I got a whole bunch of bandages for you poor bastards.");   
        }

        public override void Speak()
        {
            Console.WriteLine("PILLS HERE!");
        }
    }
}