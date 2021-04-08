namespace CursoCSharp.ClassesEMetodos
{
  public class GetSet
  {

    public class Moto
    {
      private string Marca;
      private string Modelo;
      private int Cilindrada;

      public Moto(string Marca, string Modelo, int Cilindrada)
      {
        this.Marca = Marca;
        this.Modelo = Modelo;
        this.Cilindrada = Cilindrada;
      }


      public Moto()
      {

      }


      public string GetMarca()
      {
        return Marca;
      }

      public void SetMarca(string Marca)
      {
        this.Marca = Marca;
      }
      public string GetModelo()
      {
        return Modelo;
      }

      public void SetModelo(string Modelo)
      {
        this.Modelo = Modelo;
      }

      public int GetCilindrada()
      {
        return Cilindrada;
      }
      public void SetCilindrada(int Cilindrada)
      {
        this.Cilindrada = Cilindrada;
      }

    }

    public static void Executar()
    {

      var moto2 = new Moto();
      System.Console.WriteLine("Escreva a fabricante da moto: ");
      string newFabrica = System.Console.ReadLine();
      moto2.SetMarca(newFabrica);
      System.Console.WriteLine("Escreva a Modelo da moto: ");
      string newModel = System.Console.ReadLine();
      moto2.SetModelo(newModel);
      System.Console.WriteLine("Escreva a Cilindrada da moto: ");
      int.TryParse(System.Console.ReadLine(), out int newPowe);
      moto2.SetCilindrada(newPowe);

      System.Console.WriteLine($"A sua moto é {moto2.GetMarca()}, do modelo {moto2.GetModelo()}, com a potencia de {moto2.GetCilindrada()} de cilindradas!");



    }
  }
}