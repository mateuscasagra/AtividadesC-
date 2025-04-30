using System;

public class ConversorTemperatura
{
    public static void Main(string[] args)
    {
        int opcao;

        while (true)
        {
            Console.WriteLine("\nConversor de Temperaturas");
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha uma opção: ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite a temperatura em Celsius: ");
                        string celsiusInput = Console.ReadLine();
                        if (double.TryParse(celsiusInput, out double celsius))
                        {
                            double fahrenheitResultado = (celsius * 9 / 5) + 32; // Declarei com outro nome aqui para evitar o erro, ou poderia declarar fora do if
                            Console.WriteLine($"{celsius}°C é igual a {fahrenheitResultado}°F");
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Digite um número.");
                        }
                        break;

                    case 2:
                        Console.Write("Digite a temperatura em Fahrenheit: ");
                        string fahrenheitInput = Console.ReadLine();
                        if (double.TryParse(fahrenheitInput, out double fahrenheit))
                        {
                            double celsiusResultado = (fahrenheit - 32) * 5 / 9; // Mesmo aqui
                            Console.WriteLine($"{fahrenheit}°F é igual a {celsiusResultado}°C");
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Digite um número.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Saindo do conversor.");
                        return; // Encerra o método Main, saindo do programa

                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha uma das opções do menu.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número para a opção.");
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}