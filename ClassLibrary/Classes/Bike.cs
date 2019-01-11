using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Classes
{
    public class Bike : Vehicle
    {
        enum equipment : int { gears = 24 }

        public Bike(string Name, string Model, int Seats) : base(Name, Model, Seats)
        {

        }

        public new int GetGears()
        {
            return (int)equipment.gears;
        }
    }
}
