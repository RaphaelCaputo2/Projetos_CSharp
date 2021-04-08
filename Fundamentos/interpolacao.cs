namespace CursoCSharp.Fundamentos
{
    public class interpolacao
    {
        public static void Executar(){
            string nome = "Notebook Gamer";
            var marca = "Dell";
            double preco = 5800.00;
            System.Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco + ".");
            System.Console.WriteLine($"O {nome} da {marca} custa exatamente {preco} no site do mercadoLivre");
        }
    }
}