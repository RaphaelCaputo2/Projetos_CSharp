namespace CursoCSharp.Fundamentos
{
    public class OperadoresLogicos
    {
        public static void Executar(){
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            bool comprouTv50 = executouTrabalho1 && executouTrabalho2;
            System.Console.WriteLine("Comprou a tv de 50? {0}", comprouTv50);

            var comproSorvete = executouTrabalho1 || executouTrabalho2;
            System.Console.WriteLine("Comprou sorvete? {0}", comproSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            System.Console.WriteLine("Comprou tv de 32? {0} ", comprouTv32);

            System.Console.WriteLine("Mais saudavel? {0}", !comproSorvete);

        }   
    }
}