using System;

class Program
{
    static void Main(string[] args)
    {
        int valorMaximo = 100;
        int numeroTentativas = 0;
        bool acertou = false;
        Random random = new Random();
        int numeroPensado = random.Next(1, valorMaximo + 1);
        Console.WriteLine("Jogo de adivinhacao!");
        Console.WriteLine("Qual numero estou pensando?");


        while (!acertou)
        {
            Console.WriteLine("Faca sua tentativa");
            int tentativa = Int32.Parse(Console.ReadLine());
            if (tentativa == numeroPensado)
            {
                acertou = true;
                numeroTentativas++;
                Console.WriteLine($"Parabens!! o numero que eu estava pensando era {numeroPensado}, voce acertou em {numeroTentativas} tentativas!");

            }
            else if (tentativa > numeroPensado)
            {
                Console.WriteLine("Não dessa vez! Tente Novamente OBS: O numero que pensei é Menor que a sua tentativa");
                numeroTentativas++;
            }
            else if (tentativa < numeroPensado)
            {
                Console.WriteLine("Não dessa vez! Tente Novamente OBS: O numero que pensei é Maior que a sua tentativa");
                numeroTentativas++;
            }
            else
            {
                Console.WriteLine("Entrada Inváldia");
            }


        }
    }
}
