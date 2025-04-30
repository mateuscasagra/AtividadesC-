using System;

class Program{
    static void Main(string[] args){
        Produto produto = new Produto();
        produto.CadastrarProduto("Feijao", 25.6D, 10);
        Console.WriteLine(produto.ToString());
    }
}
