using System;

class Program{
    public static void Main(string[] args){
    Imc imc = new Imc();
    Console.WriteLine("Digite seu peso");
    double peso = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite sua altura");
    double altura = double.Parse(Console.ReadLine());

    imc.CalculaIMC(peso, altura);
    imc.VerificaClassificacao();
    }
}
