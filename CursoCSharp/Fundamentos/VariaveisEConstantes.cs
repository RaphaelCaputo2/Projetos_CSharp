using System;

namespace CursoCSharp.Fundamentos
{
    public class VariaveisEConstantes
    {
        public static void Executar(){
            double raio = 4.5;
            const double PI = 3.14;


    raio = 5.5;
            double area = PI * raio * raio;
            System.Console.WriteLine(area);
            System.Console.WriteLine("Área é " + area);

        }
    }
}