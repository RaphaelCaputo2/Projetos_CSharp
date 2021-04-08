namespace CursoCSharp.ClassesEMetodos
{

  public class Desafio2
  {
    public static int b = 20;
  }
  public class DesafioAtributo
  {
    public int a = 10;
    public static void Executar()
    {
      // acessar variavel 'a' dentro do método executar!
      var desafio = new DesafioAtributo();

      System.Console.WriteLine(desafio.a);


      // var desafio2 = new Desafio2();

      System.Console.WriteLine(Desafio2.b);

    }
  }
}