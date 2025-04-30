using System;
using System.Linq;

public class ValidadorSenha
{
    public static bool IsSenhaForte(string senha)
    {
        if (string.IsNullOrEmpty(senha) || senha.Length < 8)
        {
            return false;
        }

        if (!senha.Any(char.IsUpper))
        {
            return false;
        }

        if (!senha.Any(char.IsDigit))
        {
            return false;
        }

        string caracteresEspeciais = "!@#$%&*/-_=+";
        if (!senha.Any(c => caracteresEspeciais.Contains(c)))
        {
            return false;
        }

        return true;
    }

    public static void Main(string[] args)
    {
        string senhaDigitada;
        bool senhaValida = false;

        do
        {
            Console.WriteLine("Digite sua senha:");
            senhaDigitada = Console.ReadLine();

            if (IsSenhaForte(senhaDigitada))
            {
                Console.WriteLine("Senha forte!");
                senhaValida = true;
            }
            else
            {
                Console.WriteLine("Senha fraca. Certifique-se de que ela atenda aos seguintes critérios:");
                Console.WriteLine("- Mínimo de 8 caracteres");
                Console.WriteLine("- Pelo menos uma letra maiúscula");
                Console.WriteLine("- Pelo menos um número");
                Console.WriteLine("- Pelo menos um caractere especial (!, @, #)");
                Console.WriteLine("Por favor, tente novamente.\n");
            }
        } while (!senhaValida);
    }
}