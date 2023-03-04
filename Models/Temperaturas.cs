namespace ConversorTemperaturas.Models
{
    public class Temperaturas
    {
        public double celsius = 0.0;
        public double fahrenheit = 0.0;
        public double kelvin = 0.0;

        public void ConverterCelsius(double temperatura)
        {
            fahrenheit = (temperatura * 1.8000) + 32.00;
            kelvin = (temperatura * 1.000000) + 273.15;
        }

        public void ConverterFahrenheit(double temperatura)
        {
            celsius = (temperatura - 32) / 1.8000;
            kelvin = ((temperatura - 32) / 1.8000) + 273.15;
        }

        public void ConverterKelvin(double temperatura)
        {
            celsius = temperatura - 273.15;
            fahrenheit = ((temperatura - 273.15) * 1.8000) + 273.15;
        }
    }
}