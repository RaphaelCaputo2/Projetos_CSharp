using System;
using System.Collections.Generic;
using System.Linq;


namespace CursoCSharp.TopicosAvancados
{
  public class Aluno
  {
    public string Nome;
    public int Idade;
    public int Nota;
  }
  public class Linq1
  {
    public static void Executar()
    {
      Random idade = new Random();
      var age = idade.Next(25, 65);
      Random nota = new Random();
      var points = nota.Next(7, 10);
      //   System.Console.WriteLine(age);
      //   System.Console.WriteLine(points);


      var alunos = new List<Aluno> {
                 new Aluno() {Nome = "Raphael", Idade = age, Nota = points},
                 new Aluno() {Nome = "Flavia", Idade = age, Nota = points},
                 new Aluno() {Nome = "Meg", Idade = age, Nota = points},
                 new Aluno() {Nome = "Bruno", Idade = age, Nota = points},
                 new Aluno() {Nome = "Fernanda", Idade = age, Nota = points},
                 new Aluno() {Nome = "Vera", Idade = age, Nota = points},
                 new Aluno() {Nome = "Monica", Idade = age, Nota = points},

             };

      System.Console.WriteLine("== Aprovados ===================");


      var aprovados = alunos.Where(a => a.Nota >= 7)
      .OrderBy(a => a.Nome);

      foreach (var aluno in aprovados)
      {
        System.Console.WriteLine(aluno.Idade);
      }


        System.Console.WriteLine("=== Chamada ===");
      var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
        foreach (var aluno in chamada)
      {
        System.Console.WriteLine(aluno);
      }
    }
  }
}