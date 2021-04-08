using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes

{
  public class StackColecao
  {
    public static void Executar()
    {
      var pilha = new Stack();

      pilha.Push(3);
      pilha.Push("a");
      pilha.Push(true);
      pilha.Push(3.14f);


      foreach (var item in pilha)
      {
        System.Console.WriteLine($"{item} ");
      }

      System.Console.WriteLine($"\nPop: {pilha.Pop()}");

      foreach (var item in pilha)
      {
        System.Console.WriteLine($"{item} ");
      }


      System.Console.WriteLine($"\nPeek: {pilha.Peek()}");
      System.Console.WriteLine(pilha.Count);

    }
  }
}