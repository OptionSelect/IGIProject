using System;
using System.Linq;
using System.Collections.Generic;

namespace IGIProject
{
    interface ISniper
    {
        string Rifle { get; set; }
        void NumRounds();
        void NumSmokes();
    }
}