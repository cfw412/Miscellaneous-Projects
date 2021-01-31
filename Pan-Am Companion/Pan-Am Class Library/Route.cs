using System;
using System.Collections.Generic;
using System.Text;

namespace Pan_Am_Class_Library
{
    public class Route
    {

        public Destination AirportOne { get; private set; }
        public Destination AirportTwo { get; private set; }
        public int Distance { get; private set; }

        public Route(Destination one, Destination two, int distance)
        {
            AirportOne = one;
            AirportTwo = two;
            Distance = distance;
        }
    }
}
