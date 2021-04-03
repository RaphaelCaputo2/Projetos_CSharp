namespace CursoCSharp.Colecoes
{
  public class IgualdadeColecao
  {
    public static void Executar()
    {
      var p1 = new Produto("A", 1);
      var p2 = new Produto("A", 1);
      System.Console.WriteLine(p1 == p2);

    }
  }
}