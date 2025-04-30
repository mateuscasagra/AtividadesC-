class Imc{
    public double IMC{get; set;}


    public void CalculaIMC(double kg, double m){
        IMC = kg / (m * m);
    }


    public void VerificaClassificacao(){
        if(IMC < 18.5){
            Console.WriteLine("Abaixo do peso");
        }else if(IMC <= 24.9){
            Console.WriteLine("Peso Normal");
        }else if(IMC <= 29.9){
            Console.WriteLine("Sobre peso");
        }else if(IMC < 30){
            Console.WriteLine("Obesidade");

        }
    }
}