using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Classes
{
    public class Car : Vehicle
    {
        enum equipment : int { gears = 8 }
        public Car(string Name, string Model, int Seats) : base(Name, Model, Seats)
        {

        }
        public new int GetGears()
        {
            return (int)equipment.gears;
        }
    }
}
