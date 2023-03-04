using ConversorTemperaturas.Models;

public class Program
{
    static void Main()
    {
        bool finalizaApp = false;
        double valorTemp = 0.0;
        Temperaturas temperatura = new Temperaturas();

        Console.WriteLine("Conversor de Temperaturas\r");
        Console.WriteLine("-------------------------\n");

        while (!finalizaApp)
        {
            Console.WriteLine("Selecione abaixo a unidade de temperatura que deseja converter:");
            Console.WriteLine("[c] - Celsius");
            Console.WriteLine("[f] - Fahrenheit");
            Console.WriteLine("[k] - Kelvin");
            Console.Write("Sua opção?: ");

            string opcao = Console.ReadLine();

            Console.Write("Insira o valor da temperatura escolhida: ");
            valorTemp = Convert.ToDouble(Console.ReadLine());

            switch (opcao)
            {
                case "c":
                    temperatura.ConverterCelsius(valorTemp);
                    break;
                case "f":
                    temperatura.ConverterFahrenheit(valorTemp);
                    break;
                case "k":
                    temperatura.ConverterKelvin(valorTemp);
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente...");
                    break;
            }
        }
    }
}