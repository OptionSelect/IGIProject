using System;
using System.Linq;
using System.Collections.Generic;

namespace IGIProject
{
    public abstract class Soldier
    {
        public string Name { get; set; }
        public string Rank { get; set; }
        public int SerialNumber { get; set; }

        string Sleep()
        {
            return "Zzz...";
        }
        string Eat()
        {
            return "Yum yum!";
        }
        string March()
        {
            return "Stomp stomp stomp..."
        }
    }
}