using System;
using System.Collections.Generic;
using System.Text;

namespace Pan_Am_Class_Library
{
    public class Airplane
    {
        public string Type { get; private set; }
        public int Range { get; private set; }

        public Airplane(string type)
        {
            Type = type;
            if (type == "Trimotor")
            {
                Range = 1;
            } else if (type == "Clipper")
            {
                Range = 2;
            } else if (type == "Crusier")
            {
                Range = 3;
            } else if (type == "Jet")
            {
                Range = 4;
            }
        }
    }
}
