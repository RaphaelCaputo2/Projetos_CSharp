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

      uint populacaoBrasileira = 207_600_000;
      System.Console.WriteLine("População Brasileira " + populacaoBrasileira);

      long menorValorLong = long.MinValue;
      System.Console.WriteLine("Menor long " + menorValorLong);

      ulong populacaoMundial = 7_600_000_000;
      System.Console.WriteLine("População Mundial " + populacaoMundial);

      float precoComputador = 1299.99f;
        System.Console.WriteLine("O preço do computador é " + precoComputador);

        double valorDeMercadoDaApple = 1_000_000_000_000.00;
        System.Console.WriteLine("Valoe Apple " + valorDeMercadoDaApple);

        decimal distanciaEntreEstrelas = decimal.MaxValue;
        System.Console.WriteLine("Distância entre Estrelas " + distanciaEntreEstrelas);

        char letra = 'r';
        System.Console.WriteLine("Letra " + letra);

        string texto = "Seja bem vindo ao Curso de C#!";
        System.Console.WriteLine(texto);
    }
  }
}