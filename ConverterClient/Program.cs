using System;
using ConverterLib;

namespace ConverterClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTemperatureConverter converter = new MyTemperatureConverter();

            Console.WriteLine(converter.CelsiusToFarenheit(15));
        }
    }
}
