namespace CursoCSharp.MetodosEFuncoes
{
  public class DelegateComoParametro
  {
    public delegate int Operacao(int x, int y);

    public static int Soma(int x, int y)
    {
      return x + y;
    }
    public static string Calculadora(Operacao op, int x, int y)
    {
            var resultado = op(x, y);
            return "Resultado: " + resultado;
    }

    public static void Executar()
    {

            Operacao subtracao = (int x, int y) => x - y;
            System.Console.WriteLine(subtracao(3, 1));

            


    }
  }
}