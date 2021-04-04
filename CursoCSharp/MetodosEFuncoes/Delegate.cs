using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
  delegate double Operacao(double x, double y);

  delegate double Soma(double a, double b);
  delegate void ImprimirSoma(double a, double b);



  public class LambdasDelegate
  {
    static double MinhaSoma(double x, double y)
    {
      return x + y;
    }

    public static void Executar()
    {

      Soma op1 = MinhaSoma;
      System.Console.WriteLine(op1(2, 3));





    }
  }
}