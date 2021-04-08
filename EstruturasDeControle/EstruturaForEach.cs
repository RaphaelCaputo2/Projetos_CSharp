using System;
namespace CursoCSharp.EstruturasDeControle
{
    public class EstruturaForEach
    {
        public static void Executar(){
                var frase = "Opa!";

                foreach (var fraseSplit in frase) {
                    System.Console.WriteLine(fraseSplit);
                }

                var alunos = new string[] {"Carol", "Thiago", "Moises"};

                foreach (string aluno in alunos) {
                    System.Console.WriteLine(aluno);
                }
        }
    }
}