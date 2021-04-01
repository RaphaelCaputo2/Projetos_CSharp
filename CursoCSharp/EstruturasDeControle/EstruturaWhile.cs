namespace CursoCSharp.EstruturasDeControle
{
  public class EstruturaWhile
  {
    public static void Executar()
    {

      int palpite = 0;
      System.Random random = new System.Random();

      int numeroSecreto = random.Next(1, 16);
      bool numeroEncontrado = false;
      int tentativasRestantes = 5;
      int tentativas = 0;


      while (tentativasRestantes > 0 && !numeroEncontrado)
      {

        System.Console.Write("Insira o seu palpite: ");
        string entrada = System.Console.ReadLine();
        int.TryParse(entrada, out palpite);

        tentativas++;
        tentativasRestantes--;

        if (numeroSecreto == palpite)
        {
          numeroEncontrado = true;
          var corAnterior = System.Console.BackgroundColor;
          System.Console.BackgroundColor = System.ConsoleColor.Green;
          System.Console.WriteLine("Número encontrado em {0} tentativas",
          tentativas);
          System.Console.BackgroundColor = corAnterior;

        }
        else if (palpite > numeroSecreto)
        {
          System.Console.WriteLine("Menor... Tente novamente!");
          System.Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);


        }
        else
        {
          System.Console.WriteLine("Maior... Tente Novamente!!!");
          System.Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
        }
      }
    }

  }
}