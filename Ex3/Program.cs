using System;

public class FatorialWhile
{
    public static void Main(string[] args)
    {
        int numero;

        while (true)
        {
            Console.WriteLine("Digite um número inteiro positivo para calcular o fatorial:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out numero) && numero >= 0)
            {
                break; // Sai do loop se a entrada for válida e positiva
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro positivo.\n");
            }
        }

        long fatorial = 1; // Usamos long para evitar overflow para números maiores
        int contador = numero;

        while (contador > 0)
        {
            fatorial *= contador;
            contador--;
        }

        Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
        Console.ReadKey();
    }
}