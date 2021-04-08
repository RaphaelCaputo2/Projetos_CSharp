using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;



namespace CursoCSharp.Colecoes
{
  public class QueueColecao
  {
    public static void Executar()
    {
      var fila = new Queue<string>();

      fila.Enqueue("Fulano");
      fila.Enqueue("Cicrano");
      fila.Enqueue("Beltrano");

      System.Console.WriteLine(fila.Peek()); // Pega o primeiro da fila
    System.Console.WriteLine(fila.Count);

    System.Console.WriteLine(fila.Dequeue());
    System.Console.WriteLine(fila.Count);
            foreach(var pessoa in fila) {
                System.Console.WriteLine(pessoa);
            }

            var salada = new Queue();

            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);
        System.Console.WriteLine(salada.Contains("item"));
        System.Console.WriteLine(salada.Contains("Item"));


    }
  }
}