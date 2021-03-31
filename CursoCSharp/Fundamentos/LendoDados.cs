using System;
using System.Globalization;


namespace CursoCSharp.Fundamentos
{
  class LendoDados
  {
    public static void Executar()
    {
        System.Console.WriteLine("Qual é seu nome? ");
        string nome = System.Console.ReadLine();

        System.Console.WriteLine("Qual sua idade?");
        int idade = int.Parse(System.Console.ReadLine());

        System.Console.WriteLine("Qual é seu salário? ");
        double salario = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);

        System.Console.WriteLine($"{nome} {idade} R${salario}");



        System.Console.WriteLine($"O nome do Programador é {nome}");
    }

  }
}