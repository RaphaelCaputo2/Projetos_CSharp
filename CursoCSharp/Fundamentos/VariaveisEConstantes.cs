using System;

namespace CursoCSharp.Fundamentos
{
  public class VariaveisEConstantes
  {
    public static void Executar()
    {
      double raio = 4.5;
      const double PI = 3.14;


      raio = 5.5;
      double area = PI * raio * raio;
      System.Console.WriteLine(area);
      System.Console.WriteLine("Área é " + area);

      // Tipos internos

      bool estaChovendo = true;
      System.Console.WriteLine("Está chovendo " + estaChovendo);

      byte idade = 32;
      System.Console.WriteLine("Minha idade é " + idade);

      sbyte saldoDeGols = sbyte.MinValue;
      System.Console.WriteLine("Saldo de Gols " + saldoDeGols);


      short salario = short.MinValue;
      System.Console.WriteLine("Salário " + salario);

      int menorValorInt = int.MinValue; // Mais usado dos inteiros!
      System.Console.WriteLine("Menor int " + menorValorInt);



    }
  }
}