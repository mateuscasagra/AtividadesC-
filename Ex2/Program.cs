using System;

public class Tabuada
{
    public static void Main(string[] args)
    {
        int numero;
        bool entradaValida = false;

        do
        {
            Console.WriteLine("Digite um número inteiro para ver sua tabuada:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out numero))
            {
                Console.WriteLine($"\nTabuada do {numero}:");
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numero * i;
                    Console.WriteLine($"{numero} x {i} = {resultado}");
                }
                entradaValida = true; // Define como true para sair do loop
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.\n");
            }
        } while (!entradaValida); // O loop continua até que entradaValida seja true

        Console.WriteLine("Programa finalizado.");
        Console.ReadKey();
    }
}