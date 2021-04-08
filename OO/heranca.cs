using System;
using System.Collections.Generic;
using System.Text;



namespace CursoCSharp.OO
{
  public class Carro
  {
    protected readonly int VelocidadeMaxima;
    int VelocidadeAtual;


    public Carro(int velocidadeMaxima)
    {
      VelocidadeMaxima = velocidadeMaxima;
    }
    protected int AlterarVelocidade(int delta)
    {
      int novaVelocidade = VelocidadeAtual + delta;

      if (novaVelocidade < 0)
      {
        VelocidadeAtual = 0;
      }
      else if (novaVelocidade > VelocidadeMaxima)
      {
        VelocidadeAtual = VelocidadeMaxima;
      }
      else
      {
        VelocidadeAtual = novaVelocidade;
      }
      return VelocidadeAtual;
    }

    public virtual int Acelerar()
    {
      return AlterarVelocidade(5);
    }
    public int Frear()
    {
      return AlterarVelocidade(-5);
    }

  





  }
    public class Uno : Carro
    {
      public Uno() : base(200)
      {

      }
    }
    public class Ferrari : Carro {
        public Ferrari() : base(350) {

        }

        public override int Acelerar() {
            return AlterarVelocidade(35);
        }
    }
  public class heranca
  {
    public static void Executar()
    {
        System.Console.WriteLine("Uno...");
        Uno carro1 = new Uno();
      System.Console.WriteLine(carro1.Acelerar());
      System.Console.WriteLine(carro1.Acelerar());
      System.Console.WriteLine(carro1.Frear());
      System.Console.WriteLine(carro1.Frear());
      System.Console.WriteLine(carro1.Frear());

            Ferrari carro2 = new Ferrari();
            System.Console.WriteLine("Ferrari...");
      System.Console.WriteLine(carro2.Acelerar());
      System.Console.WriteLine(carro2.Acelerar());
      System.Console.WriteLine(carro2.Acelerar());
      System.Console.WriteLine(carro2.Acelerar());
      System.Console.WriteLine(carro2.Acelerar());
      System.Console.WriteLine(carro2.Acelerar());
      System.Console.WriteLine(carro2.Acelerar());





    }
  }
}