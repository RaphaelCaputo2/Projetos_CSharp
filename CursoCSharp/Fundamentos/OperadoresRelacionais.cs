namespace CursoCSharp.Fundamentos
{
    public class OperadoresRelacionais
    {
        public static void Executar(){
        //    double nota = 6.0;
        double.TryParse(System.Console.ReadLine(), out double nota);
           double NotaDeCorte = 7.0;

           System.Console.WriteLine("Nota inválida? {0}", nota > 10.0);
           System.Console.WriteLine("Nota inválida? {0}", nota < 0.0);
           System.Console.WriteLine("Perfeito? {0}", nota == 10.0);
           System.Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
           System.Console.WriteLine("Passou por média? {0}", nota >= NotaDeCorte);
           System.Console.WriteLine("Recuperação? {0}", nota < NotaDeCorte);
           System.Console.WriteLine("Reprovado? {0}", nota <= 3.0);
        }
    }
}