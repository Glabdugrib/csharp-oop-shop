namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prodotto prod1 = new Prodotto("Libro", "Libro molto interessante", 19.99f, 22f);
            prod1.ToString();
            Console.WriteLine("\n" + prod1.getNomeEsteso());
            Console.WriteLine("\n" + prod1.getPrezzoIva());
            Console.WriteLine("\n" + prod1.getPaddedCodice());

            Console.WriteLine();

            Prodotto prod2 = new Prodotto("Videogioco", "Videogioco PS4, genere sparatutto", 59.99f, 22f);
            prod1.ToString();
            Console.WriteLine("\n" + prod2.getNomeEsteso());
            Console.WriteLine("\n" + prod2.getPrezzoIva());
            Console.WriteLine("\n" + prod2.getPaddedCodice());
        }
    }
}
