using System;
using System.Linq;
using System.Collections.Generic;

namespace IGIProject
{
    interface IPilot
    {
        string Aircraft { get; set; }
        void NumMissiles();
        void NumBullets();
        void NumBombs();

    }
}