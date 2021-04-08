namespace CursoCSharp.ClassesEMetodos
{
  class Membros
  {
    public static void Executar()
    {
      Pessoa sicrano = new Pessoa();
      sicrano.Nome = "Raphael";
      sicrano.Idade = 32;
      System.Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos e esse ano vai fazer {sicrano.Idade + 1}");

      Pessoa fulano = new Pessoa();
      System.Console.WriteLine("Digite seu Nome: ");
      fulano.Nome = System.Console.ReadLine();
      System.Console.WriteLine("Digite sua Idade: ");
      var idade = System.Console.ReadLine();
      int.TryParse(idade, out fulano.Idade);

    

      fulano.Apresentar();





    }
  }
}