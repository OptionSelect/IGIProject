using System;
namespace IGIProject
{
    public class Pilot : Soldier, IPilot
    {
        public Pilot(string name, string rank, int serial) : base(new Aircraft())
        {
            Name = name;
            Rank = rank;
            SerialNumber = serial;
        }

        public string Aircraft { get; set; }

        public void NumBombs()
        {
            Console.WriteLine("We got loads'a bombs here!");
        }

        public void NumBullets()
        {
            Console.WriteLine("We got tons'a bullets here!");
        }

        public void NumMissiles()
        {
            Console.WriteLine("Don't even get me started on them missles!");
        }

        public override void Speak()
        {
            Console.WriteLine("In the pipe, 5 by 5.");  
        }
    }
}