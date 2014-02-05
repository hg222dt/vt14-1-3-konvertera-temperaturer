using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConvertTemp.Model
{
    public static class TemperatureConverter
    {
        public static void CelsiusToFahrenheit(int degreesC)
        {
            double degreesF = degreesC * 1.8 + 32;

        }

        public static void FahrenheitToCelcius(int degreesF)
        {
            double degreesC = (degreesF - 32) / 1.8;

        }
    }
}