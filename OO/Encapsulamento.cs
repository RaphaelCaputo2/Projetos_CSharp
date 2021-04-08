namespace CursoCSharp.OO
{


  public class Comida
  {
    public double Peso;
    public Comida(double peso)
    {
      Peso = peso;
    }
    public Comida() { }
  }
  public class Feijao : Comida
  {

  }
  public class Arroz : Comida
  {

  }
  public class Abdominal : Comida
  {

  }
  public class Carne : Comida
  {

  }
  public class Pessoa
  {
    public double Peso;

    // public void Comer(Feijao feijao){
    //     Peso += feijao.Peso;
    // }
    //   public void Comer(Arroz arroz){
    //     Peso += arroz.Peso;
    // }
    //   public void Comer(Carne carne){
    //     Peso += carne.Peso;
    // }

    public void Comer(Comida comida)
    {
      Peso += comida.Peso;
    }
    public void Malhar(Comida comida)
    {
      Peso -= comida.Peso;
    }


  }


  class Polimorfismo
  {
    public static void Executar()
    {
      Pessoa cliente = new Pessoa();
      Pessoa cliente2 = new Pessoa();


      Feijao ingredient1 = new Feijao();
      ingredient1.Peso = 0.15;
      Arroz ingredient2 = new Arroz();
      ingredient2.Peso = 0.35;
      Abdominal exercicio = new Abdominal();
      exercicio.Peso = 9.9;
      Carne ingredient3 = new Carne();
      ingredient3.Peso = 0.90;
 
      cliente.Peso = 130.2;
      cliente.Comer(ingredient3);
      cliente.Comer(ingredient3);
      cliente.Comer(ingredient3);
      cliente.Comer(ingredient3);
      cliente.Malhar(exercicio);


      System.Console.WriteLine($"O peso atual é {cliente.Peso}");
cliente.Malhar(exercicio);
      System.Console.WriteLine($"O peso agora é {cliente.Peso}");

    }
  }
}