namespace CursoCSharp.ClassesEMetodos
{
  public class CarroOpcional
  {
    double desconto = 0.1;

    string nome;

    public string Nome{ get; set; }


    public double Preco { get; set; }




    public double PrecoComDesconto
    {
      get => Preco - (desconto * Preco);
    }


    public CarroOpcional()
    {

    }
    public CarroOpcional(string nome, double preco)
    {
      Nome = nome;
      Preco = preco;
    }
  }
  public class Props
  {
    public static void Executar()
    {
      var op1 = new CarroOpcional("Ar Condicionado", 3499.9);
            op1.Nome = "Queixo Duro";
            op1.Preco = 1000;
        System.Console.WriteLine(op1.Nome);
        System.Console.WriteLine(op1.PrecoComDesconto);
    }
  }
}