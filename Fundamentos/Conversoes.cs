namespace CursoCSharp.Fundamentos
{
  public class Conversoes
  {
    public static void Executar()
    {
      double nota = 9.7;
      int notaTruncada = (int)nota;
      System.Console.WriteLine("Nota truncada: {0}", notaTruncada);


      System.Console.WriteLine("Digite sua idade: ");
      string stringIdade = System.Console.ReadLine();

      int intIdade = int.Parse(stringIdade);
      System.Console.WriteLine("Idade inserida: {0}", intIdade);

      intIdade = System.Convert.ToInt32(stringIdade);
      System.Console.WriteLine("Resultado: {0}", intIdade);


      System.Console.WriteLine("Digite um número");
      string palavra = System.Console.ReadLine();

      int.TryParse(palavra, out int numero);
      System.Console.WriteLine(numero);

    }
  }
}