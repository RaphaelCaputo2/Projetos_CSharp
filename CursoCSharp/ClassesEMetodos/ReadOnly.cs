namespace CursoCSharp.ClassesEMetodos
{
  public class Cliente
  {
    public string Nome;
    readonly System.DateTime Nascimento;

    public Cliente(string nome, System.DateTime nascimento)
    {
      Nome = nome;
      Nascimento = nascimento;

    }
    public string GetDataDeNascimento()
    {
      return System.String.Format("{0}/{1}/{2}", Nascimento.Day,
      Nascimento.Month, Nascimento.Year);
    }
  }
  public class ReadOnly
  {
    public static void Executar()
    {
      var novoCliente = new Cliente("Raphael Caputo", new System.DateTime(1988, 04, 27));
      System.Console.WriteLine(novoCliente.Nome);

      System.Console.WriteLine(novoCliente.GetDataDeNascimento());
    }
  }
}