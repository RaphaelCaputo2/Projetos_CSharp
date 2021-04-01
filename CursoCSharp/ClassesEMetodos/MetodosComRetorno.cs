namespace CursoCSharp.ClassesEMetodos
{
  class CalculadoraComum
  {
    public int Somar(int a, int b)
    {
      return a + b;
    }
    public int Subtrair(int a, int b)
    {
      return a - b;
    }
    public int Multiplicar(int a, int b)
    {
      return a * b;
    }
    public int Dividir(int a, int b)
    {
      return a / b;
    }
  }
  public class MetodosComRetorno
  {
    public static void Executar()
    {
      System.Console.WriteLine("Qual Operação Voce Quer Fazer? Somar, Multiplicar, Subtrair, Dividir ");
      string funcao = System.Console.ReadLine();

      System.Console.Write($"Primeiro número da {funcao}: ");
      int.TryParse(System.Console.ReadLine(), out int NumA);
      System.Console.Write($"Segundo número da {funcao}: ");
      int.TryParse(System.Console.ReadLine(), out int NumB);
      var calculadora = new CalculadoraComum();
      int resultado = 0;

      switch (funcao)
      {
        case "Somar":
          resultado = calculadora.Somar(NumA, NumB);
          break;
        case "Subtrair":
          resultado = calculadora.Subtrair(NumA, NumB);
          break;
        case "Multiplicar":
          resultado = calculadora.Multiplicar(NumA, NumB);
          break;
        case "Dividir":
          resultado = calculadora.Dividir(NumA, NumB);
          break;

      }

      System.Console.WriteLine($"O resultado da sua calculadora é {resultado}");



      //   System.Console.WriteLine("O resultado da soma é {0}", resultado);
    }


  }
}