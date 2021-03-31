namespace CursoCSharp.Fundamentos
{
  class NotacaoPonto
  {
    public static void Executar()
    {
      var saudacao = "Olá ".ToUpper().Insert(3, " World").Replace("World", "Mundo");
      System.Console.WriteLine(saudacao);


      string valorImportante = "OLA RAPHAEL";

      System.Console.WriteLine(valorImportante?.Length);



    }
  }
}