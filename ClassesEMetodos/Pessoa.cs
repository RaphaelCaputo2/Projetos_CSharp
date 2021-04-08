namespace CursoCSharp.ClassesEMetodos
{
  class Pessoa
  {

    public string Nome;

    public int Idade;



    public string Apresentacao()
    {
      return string.Format($"Olá! Me chamo {Nome} e tenho {Idade}");
    }
    public void Apresentar()
    {
      if (Nome.Length <= 0)
      {
        System.Console.WriteLine("Nome Invalido");

      }
      else if (Idade <= 0)
      {
        System.Console.WriteLine("Idade Inválida");
      } else {
          System.Console.WriteLine(Apresentacao());
      }

    }
  }
}
