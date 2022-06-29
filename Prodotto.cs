using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {

        public int Codice 
        { 
            get;
            private set;
        }

        public string Nome { get; set; }

        public string Descrizione { get; set; }

        public float Prezzo { get; set;  }

        public float Iva { get; set; }

        public Prodotto(string nome, string descrizione, float prezzo, float iva)
        {
            Random random = new Random();
            Codice = random.Next(1, 1000);
            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Iva = iva;
        }

        public void ToString()
        {
            Console.WriteLine("Istanza di Prodotto");
            Console.WriteLine($"Codice: {Codice}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Descrizione: {Descrizione}");
            Console.WriteLine($"Prezzo: {Prezzo} euro");
            Console.WriteLine($"Iva: {Iva}%");
        }

        public string getNomeEsteso()
        {
            return Codice + " - " + Nome;
        }

        public float getPrezzoIva()
        {
            return Prezzo * (1 + Iva / 100);
        }

        public string getPaddedCodice()
        {
            string strCodice = Codice.ToString();
            int zerosNum = 8 - strCodice.Length;
            string paddedCodice = "";

            for (int i = 0; i < zerosNum; i++)
            {
                paddedCodice += "0";
            }

            paddedCodice += strCodice;

            return paddedCodice;
        }
    }
}
