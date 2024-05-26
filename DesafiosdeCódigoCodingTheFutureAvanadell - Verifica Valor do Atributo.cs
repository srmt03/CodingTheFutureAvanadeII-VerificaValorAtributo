using System;

class Program
{
    static bool VerificarAtributo(int valorMinimo, int valorMaximo, int valorAtributo)
    {
        if (valorAtributo <= valorMaximo && valorAtributo >= valorMinimo)
        {
          return true;
        } 
        else
        {
          return false;
        }
    }

    static void Main(string[] args)
    {
        // Nome do Atributo
        string atributo = Console.ReadLine();
        
        int valorMinimo = int.Parse(Console.ReadLine());

        int valorMaximo = int.Parse(Console.ReadLine());

        int valorAtributo = int.Parse(Console.ReadLine());

        bool validaValorAtributo = VerificarAtributo(valorMinimo, valorMaximo, valorAtributo);
        
        if (validaValorAtributo)
        {
          Console.WriteLine("O valor do atributo está dentro do intervalo especificado");
        }
        else
        {
          Console.WriteLine("O valor do atributo está fora do intervalo especificado");
        }
    }
}