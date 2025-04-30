class Produto{

    public string nome{get;set;}
    public double preco{get;set;}
    public int quantidade{get;set;}
   


    public void CadastrarProduto(string nome, double preco, int quantidade){
        this.nome = nome;
        this.preco = preco; 
        this.quantidade = quantidade;
    }

    public double ValorEmEstoque(){
       
        return preco * quantidade;
    }

    public string ToString(){
        return $"Produto {nome}, Preco {preco}, Quantidade {quantidade} Valor em Estoque: {ValorEmEstoque()}";
    }
}