namespace CursoCSharp.Fundamentos
{
    public class OperadoresAritmeticos
    {
        public static void Executar(){
          var preco = 1000.0;
          var imposto = 355;
          var desconto = 0.1;

          double total = preco + imposto;
          var totalComDesconto = total - (total * desconto);
          System.Console.WriteLine("O preço final é {0}", totalComDesconto);


          //IMC
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / System.Math.Pow(altura, 2);
            System.Console.WriteLine($"IMC é {imc}.");


            //Número Par/Impar
            int par = 24;
            int impar = 55;
            System.Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            System.Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}