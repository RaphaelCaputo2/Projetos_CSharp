namespace CursoCSharp.EstruturasDeControle
{
  public class EstruturaIf
  {
    public static void Executar()
    {
      bool bomComportamento = false;
      string entrada;
      System.Console.WriteLine("Digite a nota do aluno: ");
      entrada = System.Console.ReadLine();
      System.Double.TryParse(entrada, out double nota);
      System.Console.WriteLine("Possui bom comportamento (S/N): ");
      entrada = System.Console.ReadLine();

      bomComportamento = entrada.ToLower() == "s";
      if (nota >= 9.0 && bomComportamento)
      {
        System.Console.WriteLine("Quadro de honra!");
      }
      else
      {
        System.Console.WriteLine("Longe da escola por favor!");
      }
    }
  }
}