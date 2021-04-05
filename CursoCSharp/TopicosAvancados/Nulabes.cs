using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
  public class Nulabes
  {
    public static void Executar()
    {
      Nullable<int> num1 = null;
      int? num2 = null;

      if(num1.HasValue) {
          System.Console.WriteLine($"Valor do num: {num1}");
      } else {
          System.Console.WriteLine("A variavel nao possui valor");
      }
      int valor = num1 ?? 1000;

      System.Console.WriteLine("Valor " + valor);
    }
  }
}