using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConvertTemp.Model
{
    public static class TemperatureConverter
    {
        public static int CelsiusToFahrenheit(int degreesC)
        {
            double degreesF = degreesC * 1.8 + 32;

            return (int)degreesF;
        }

        public static int FahrenheitToCelcius(int degreesF)
        {
            double degreesC = (degreesF - 32) / 1.8;

            return (int)degreesC;
        }
    }
}