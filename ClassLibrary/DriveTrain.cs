using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    //Jag använde mig av struct för tyckte passade bra för drivmedel
    public struct DriveTrain
    {
        public string Uses { get; set; }

        public int Liters { get; set;  }

        public override string ToString()
        {
            return $"Uses: {Uses}, Liters: {Liters}";
        }
    }
}
