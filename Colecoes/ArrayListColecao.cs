using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
  public class ArrayListColecao
  {
    public static void Executar()
    {
      var arraylist = new ArrayList {
            "Palavra",
            3,
            true
        };

      arraylist.Add(3.14);
      foreach (var item in arraylist)
      {
        System.Console.WriteLine("{0} => {1}", item, item.GetType());
      }

    }
  }
}