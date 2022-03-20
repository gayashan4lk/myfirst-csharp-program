using System;

namespace MyUtilities
{
    class WeatherUtilities
    {
        static public float FahrenheitToCelsius(float tempFahrenheit)
        {
            return (float)(tempFahrenheit - 32 / 1.8f);
        }

        static public float CelciusToFahrenheit(float tempCelcius)
        {
            return (float)(tempCelcius * 1.8f + 32);
        }

        // The higher the index, the lower the comfort.
        static private float ComfortIndex(float tempFahrenheit, float humidityPercent)
        {
            // Probably not a very reliable formula
            return (tempFahrenheit + humidityPercent) / 4;
        }

        static public void Report(string location, float tempCelsius, float humidity)
        {
            var tempFahrenheit = CelciusToFahrenheit(tempCelsius);
            Console.WriteLine($"Confort Index for {location} : {ComfortIndex(tempFahrenheit, humidity)}");
        }
    }
}