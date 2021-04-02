namespace CursoCSharp.ClassesEMetodos
{
  public struct SPonto
  {
    public int X;
    public int Y;

  }

  public class CPonto
  {
    public int X;
    public int Y;
  }
  public class StructVsClasse
  {
    public static void Executar()
    {   
        SPonto ponto1 = new SPonto { X = 2, Y = 3};
        CPonto ponto2 = new CPonto { X = 1, Y = 2};
        SPonto copiaPonto1 = ponto1;

        ponto1.X = 3;

        System.Console.WriteLine(ponto1.X);
        System.Console.WriteLine(copiaPonto1.X);

    }
  }
}