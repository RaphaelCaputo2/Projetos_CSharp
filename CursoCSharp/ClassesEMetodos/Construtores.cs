namespace CursoCSharp.ClassesEMetodos
{

  class Carro
  {
    public string Modelo;
    public string Fabricante;
    public int Ano;


    public Carro(string modelo, string fabricante, int ano)
    {
      Modelo = modelo;
      Fabricante = fabricante;
      Ano = ano;

    }
    public Carro()
    {

    }
  }
  public class Construtores
  {
    public static void Executar()
    {
      var carro1 = new Carro();
      carro1.Fabricante = "Wolks";
      carro1.Modelo = "SpaceFox";
      carro1.Ano = 2014;
      System.Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");


        var fabrica = "Toyota";
        var model = "Hillux";
        var fabricacao = 2011;
      var carro2 = new Carro(model, fabrica, fabricacao);

      System.Console.WriteLine($"O carro do raphael é um {carro2.Fabricante}, no modelo{carro2.Modelo}, Fabricado no ano {carro2.Ano}");

    }
  }
}