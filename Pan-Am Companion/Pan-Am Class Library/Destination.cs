using System;
using System.Collections.Generic;
using System.Text;

namespace Pan_Am_Class_Library
{
    public class Destination
    {

        public string Region { get; private set; }
        public string Name { get; private set; }

        public Destination(int region)
        {
            if (region == 1)
            {
                Region = "Asia";
            } else if (region == 2)
            {
                Region = "Europe";
            } else if (region == 3)
            {
                Region = "North America";
            } else if (region == 4)
            {
                Region = "Pacific";
            } else if (region == 5)
            {
                Region = "South America";
            }
            
        }

    }
}
