using System;

namespace MyUtilities
{
    class WeatherUtilities
    {
        static float FahrenheitToCelsius(float tempFahrenheit)
        {
            var tempCelsius = tempFahrenheit - 32 / 1.8f;
            return tempCelsius;
        }

        static float CelciusToFahrenheit(float tempCelcius)
        {
            var tempFahrenheit = tempCelcius * 1.8f + 32;
            return tempFahrenheit;
        }

        static float ComfortIndex(float tempFahrenheit, float humidityPercent)
        {
            var comfortIndex = (tempFahrenheit + humidityPercent) / 4;
            return comfortIndex;
        }
    }
}