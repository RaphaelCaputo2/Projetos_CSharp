using System;
using System.IO;

namespace CursoCSharp.Api
{
  public class LendoArquivos
  {
    public static void Executar()
    {
      var path = @"~/lendoarquivos.txt".ParseHome();

      if (!File.Exists(path))
      {
        using (StreamWriter sw = File.AppendText(path))
        {
          sw.WriteLine("Produto; Preço; QTDE");
          sw.WriteLine("Caneta Bic Preta; 3.59;89");
          sw.WriteLine("Borracha Branca;2.89;2");


        }
    }
            try {
                using (StreamReader sr = new StreamReader(path)){
                    var texto = sr.ReadToEnd();
                    System.Console.WriteLine(texto);
                }

            } catch(Exception ex) {
                System.Console.WriteLine(ex.Message);
            }




    }
  }
}