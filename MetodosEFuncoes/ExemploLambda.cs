using System;
using System.Collections.Generic;
using System.Text;




namespace CursoCSharp.MetodosEFuncoes
{
    public class ExemploLambda
    {
        public static void Executar () {
            Action algoNoConsole = () => {
                System.Console.WriteLine("Lambda com C#! ");
            };

            algoNoConsole();

            Func<int> jogarDado = () => {
          Random random = new Random();
                    return random.Next(1, 10);
            };
            System.Console.WriteLine(jogarDado());



        Func<int, string> conversorHex = numero => numero.ToString("X");


           System.Console.WriteLine(conversorHex(123456));
        }
    }
}