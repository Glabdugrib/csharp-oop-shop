namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prodotto prod1 = new Prodotto("Libro", "Libro molto interessante", 19.99f, 2f);
            prod1.ToString();
        }
    }
}
