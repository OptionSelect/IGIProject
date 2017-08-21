using System;
using System.Linq;
using System.Collections.Generic;

namespace IGIProject
{
    interface IMedic
    {
        string Medkit { get; set; }
        void NumBandages();
        void NumAlcohol();
    }
}