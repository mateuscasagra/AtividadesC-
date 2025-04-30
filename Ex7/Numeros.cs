class Numeros{
   public int[] numeros  = new int[10];
   public int totalNumerosPares;



   public void PedeDezNumeros(){
    for (int i = 0; i < 10; i++){
        Console.WriteLine($"Digite o numero {i}");
        numeros[i] = Int32.Parse(Console.ReadLine());
    }
   }


   public void CalculaNumerosPares(){
    for(int i = 0; i < 10; i++) {
        if(numeros[i] % 2 == 0){
            totalNumerosPares += numeros[i];
        }
    }
   }

   public override string ToString(){
    return $"total de pares: {totalNumerosPares}";
   }
}