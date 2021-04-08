namespace CursoCSharp.Fundamentos
{
  class FormatandoNumeros
  {
    public static void Executar()
    {
        double valor = 15.175;
        System.Console.WriteLine(valor.ToString("F1")); // Arredonda o numero flutuante setado
        System.Console.WriteLine(valor.ToString("C")); // Coloca a moeda corrente do computador de origem
        System.Console.WriteLine(valor.ToString("P")); // Porcentagem
        System.Console.WriteLine(valor.ToString("#.##")); 



        int inteiro = 256;
        System.Console.WriteLine(inteiro.ToString("D10"));
        
    }
  }
}