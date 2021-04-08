using System;
using System.Collections.Generic;
using System.Text;


namespace CursoCSharp.Colecoes
{

  public class Produto
  {
    public string Nome;
    public double Preco;

    public Produto(string nome, double preco)
    {
      Nome = nome;
      Preco = preco;
    }


  }
  public class ListColecao
  {
    public static void Executar()
    {
      var livro = new Produto("Game of Thrones", 49.99);

      var carrinho = new List<Produto>();
      carrinho.Add(livro);

      var combo = new List<Produto>{
            new Produto("Camisa", 29.9),
            new Produto("HIMYM 3", 29.5),
            new Produto("Poster", 10)
        };

      carrinho.AddRange(combo);
      System.Console.WriteLine(carrinho.Count);
      carrinho.RemoveAt(3);


      foreach (var item in carrinho)
      {
        System.Console.WriteLine(carrinho.IndexOf(item));
        System.Console.WriteLine($"{item.Nome} {item.Preco}");
      }

    

    }
  }
}