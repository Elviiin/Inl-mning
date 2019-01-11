using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Classes
{
    public class Vehicle : IntefaceVehicle
    {
        public string name { get; set; }

        public string model { get; set; }

        public int seats { get; set; }


        enum equipment : int { gears = 5}
        

        public Vehicle()
        {

        }


        public Vehicle(string Name, string Model, int Seats)
        {
            this.name = Name;
            this.model = Model;
            this.seats = Seats;
            
        }

        public int GetGears()
        {
            return (int) equipment.gears;
        }
    }

}
