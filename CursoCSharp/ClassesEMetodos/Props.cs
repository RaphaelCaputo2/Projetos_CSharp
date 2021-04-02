namespace CursoCSharp.ClassesEMetodos
{
  public class CarroOpcional
  {
    double desconto = 0.5;

    string nome;

    public string Nome { get; set; }


    public double Preco { get; set; }



    public double Desconto { get; set; }
    public double PrecoComDesconto
    {
      get => Preco - (Desconto * Preco);
    }


    public CarroOpcional()
    {

    }
    public CarroOpcional(string nome, double preco, double desconto)
    {
      Nome = nome;
      Preco = preco;
      Desconto = desconto;
    }
  }
  public class Props
  {
    public static void Executar()
    {
      var op1 = new CarroOpcional("Ar Condicionado", 3499.9, 0.3);
      op1.Nome = "Vidro elétrico";
      op1.Preco = 1000;
      op1.Desconto = 0.9;
      System.Console.WriteLine($"O produto: {op1.Nome} tem o preço de: R${op1.Preco},00 , mas com desconto de {op1.Desconto * 100}%, ele irá sair por {op1.PrecoComDesconto}");
      // System.Console.WriteLine(op1.Nome);
      // System.Console.WriteLine(op1.PrecoComDesconto);
    }
  }
}