using System;


class Program{
    static void Main(string[] args){
        Numeros num = new Numeros();
        num.PedeDezNumeros();
        num.CalculaNumerosPares();
        Console.WriteLine(num.ToString());
    }
}
