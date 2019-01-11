using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    //Här använder jag mig utav interface för att definera egenskaper och metoder till klasserna som använder interfacet
    public interface IntefaceVehicle
    {
        string name { get; set; }

        string model { get; set; }

        int seats { get; set; }

        int GetGears();
    }
}
