using System;
using System.Collections.Generic;

namespace Pan_Am_Class_Library
{
    public class Player
    {

        public string Name { get; set; }
        public bool is_FirstPlayer { get; set; }
        public int Income { get; set; }
        public int Money { get; set; }
        public int Stocks { get; set; }
        public int Airports { get; set; }
        public List<Destination> LandingRights { get; set; }
        public List<Route> Routes { get; set; }
        public List<Airplane> Fleet { get; set; }


        public Player()
        {
            Console.Write("Enter your name: ");
            Name = Console.ReadLine();
            is_FirstPlayer = false;
            Airports = 0;
            Income = CalculateIncome();
            Money = 12;
            Stocks = 0;
        }

        public int CalculateIncome()
        {
            int inc = 0;
            foreach(Route r in Routes)
            {
                inc += r.Distance;
            }
            inc += Airports;
            return inc;
        }

        public void AddMoney(int m)
        {
            Money += m;
        }
    }
}
