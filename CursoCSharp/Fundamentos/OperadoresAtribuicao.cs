namespace CursoCSharp.Fundamentos
{
    public class OperadoresAtribuicao
    {
        public static void Executar(){
          var num1 = 3;
          num1 = 7;
          num1 += 10;
          num1 -= 3;
          num1 *= 5;
          num1 /= 2; 
          System.Console.WriteLine(num1);

          int a = 1;
          int b = a;

          a++;
          b++;

          System.Console.WriteLine($"{a} {b}");


          dynamic c = new System.Dynamic.ExpandoObject();

          dynamic d = c;
          d.nome = "Meg";

          System.Console.WriteLine(c.nome);
        }
    }
}