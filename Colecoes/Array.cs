namespace CursoCSharp.Colecoes
{
  public class ArrayColecao
  {
    public static void Executar()
    {
      string[] alunos = new string[5];
      alunos[0] = "Raphael";
      alunos[1] = "Flavia";
      alunos[2] = "Meg";
      alunos[3] = "Eliza";
      alunos[4] = "Bruno";


      foreach (var aluno in alunos)
      {
        System.Console.WriteLine($"O nome do aluno é {aluno}");
      }

    }
  }
}