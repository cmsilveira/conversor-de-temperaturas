using ConversorTemperaturas.Models;

namespace ConversorTemperaturas
{
    public class Program
    {
        static void Main()
        {
            bool finalizaApp = false;
            double valorTemp = 0.0;
            var temperatura = new Temperaturas();

            Console.WriteLine("Conversor de Temperaturas\r");
            Console.WriteLine("-------------------------\n");

            while (!finalizaApp)
            {
                Console.WriteLine("Selecione abaixo a unidade de temperatura que deseja converter:");
                Console.WriteLine("[c] - Celsius");
                Console.WriteLine("[f] - Fahrenheit");
                Console.WriteLine("[k] - Kelvin");
                Console.WriteLine("[s] - Sair");
                Console.Write("Sua opção?: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "c":
                        temperatura.ConverterCelsius(valorTemp);
                        temperatura.ImprimirCelsius();
                        break;
                    case "f":
                        temperatura.ConverterFahrenheit(valorTemp);
                        break;
                    case "k":
                        temperatura.ConverterKelvin(valorTemp);
                        break;
                    case "s":
                        Console.WriteLine("Finalizando...");
                        
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente...");
                        break;
                }
                Console.WriteLine("Pressione <n> e <Enter> para finalizar o aplicativo, ou pressione <y> para continuar...");
                if (Console.ReadLine() == "n")
                    finalizaApp = true;

                Console.WriteLine("\n");
            }
        }
    }
}