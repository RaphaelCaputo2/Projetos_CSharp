using System;
using System.Collections.Generic;



namespace CursoCSharp.OO
{
  interface OperacaoBinaria
  {
    int Operacao(int a, int b);
  }

  class Soma : OperacaoBinaria
  {
    public int Operacao(int a, int b)
    {
      return a + b;
    }
  }

  class Subtracao : OperacaoBinaria
  {
    public int Operacao(int a, int b)
    {
      return a - b;
    }
  }

  class Calculadora
  {
    List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>{
            new Soma(),
            new Subtracao()
        };

    public string ExecutarOperacoes(int a, int b)
    {
      string resultado = "";

      foreach (var op in operacoes)
      {
        resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}";
      }
      return resultado;
    }
  }



  public class Interface
  {
    public static void Executar()
    {
                Calculadora calc = new Calculadora();
                var resultado = calc.ExecutarOperacoes(20, 5);
                System.Console.WriteLine(resultado);

    }
  }
}