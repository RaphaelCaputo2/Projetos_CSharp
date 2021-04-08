namespace CursoCSharp.EstruturasDeControle
{
  public class EstruturaSwitch
  {
    public static void Executar()
    {
      System.Console.WriteLine("Avalie a sua nota!");
      int.TryParse(System.Console.ReadLine(), out int nota);

      switch (nota)
      {
        case 0:
          System.Console.WriteLine("Péssimo meu jovem");
          break;
        case 1:
        case 2:
          System.Console.WriteLine("Pelo menos conseguiu fazer algum ponto né?");
          break;
        case 3:
          System.Console.WriteLine("Médiano");
          break;
        case 4:
          System.Console.WriteLine("Aqui voce quase conseguiu excelencia");
          break;
        case 5:
          System.Console.WriteLine("Excelente meu jovem gafanhoto");
          break;
        default:
          System.Console.WriteLine("Nota inválida seu corno!");
          break;

      }
    }
  }
}