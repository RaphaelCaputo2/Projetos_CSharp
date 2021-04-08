namespace CursoCSharp.EstruturasDeControle
{
  public class EstruturaFor
  {
    public static void Executar()
    {

      double somatorio = 0; // cria uma variavel que pode receber numero flutuante
      string entrada; // cria variavel que recebe o numero digitado no console

      System.Console.WriteLine("Informe o tamanho da turma: ");
      entrada = System.Console.ReadLine(); // Le o que foi digitado
      int.TryParse(entrada, out int tamanhoTurma); // transforma(parse) o que foi digitado em um inteiro e cria a variavel TAMANHOTURMA


        // laço de repetição que faz a função
        // 
      for (int i = 0; i < tamanhoTurma; i++)
      {
        System.Console.WriteLine("Informe a nota do aluno {0}: ", i);
        entrada = System.Console.ReadLine();
        double.TryParse(entrada, out double notaAtual);
        somatorio += notaAtual;
      }
      double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
      System.Console.WriteLine("Media da turma: {0}", media);

    }
  }
}