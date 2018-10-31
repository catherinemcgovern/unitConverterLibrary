using System;

namespace ConverterLib
{
    interface ITemperatureConverter
    {
        decimal CelsiusToFarenheit(decimal TempInCelsius);


    }
    public class MyTemperatureConverter : ITemperatureConverter
    {
        public decimal CelsiusToFarenheit(decimal TempInCelsius)
        {
            //F=C*(9/5) +32
            return TempInCelsius * (9m/5m) + 32;
        }

    }



    
    public class AlternativeTemperatureConverter : ITemperatureConverter
    {
        public decimal CelsiusToFarenheit(decimal TempInCelsius)
        {
            //F=C*(9/5) +32
            return TempInCelsius * (1.8m) + 32;
        }
        
    }

}

