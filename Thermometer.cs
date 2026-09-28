using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace extrauppgifter
{
    public class Thermometer
    {
        public double Temperature { get; set; }

        public string CheckTemperature()
        {
            if (Temperature < 0)
            {
                return "Det är minusgrader";
            }
            else if (Temperature > 30)
            {
                return "Varning för hög värme";
            }
            else
            {
                return "Normal temperatur";
            }
        }
    }
}
