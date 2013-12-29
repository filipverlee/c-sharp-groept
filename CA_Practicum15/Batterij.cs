using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Practicum15
{
    class Batterij
    {
        private int code;
        private double voltage;

        public int Code { get; set; }
        public double Voltage { get; set; }

        public Batterij()
        {
            Code = 0;
            Voltage = 0;
        }

        public Batterij(int code, double voltage)
        {
            Code = code;
            Voltage = voltage;
        }
        
        public string GeefOmschrijving()
        {
            return "Code: b" + Code + "/ Voltage: " + Voltage + Environment.NewLine;
        }
    }
}
