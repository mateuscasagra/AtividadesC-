using System;

class Program{

public static void Main(string[] args){
    Console.WriteLine("Digite uma palavra");
    string palavra = Console.ReadLine();
    InvertePalavra(palavra);
}


public static void InvertePalavra(string palavra){
    char[] array = palavra.ToCharArray();
    Array.Reverse(array);
    string palavraInvertida = new string(array);
    Palíndromos(palavraInvertida, palavra);
}

public static void Palíndromos(string palavraInvertida, string palavra){
    if(palavraInvertida == palavra){
        Console.WriteLine("Palíndromos");
    }else{
        Console.WriteLine("Não são Palíndromo");
    }
}
}

