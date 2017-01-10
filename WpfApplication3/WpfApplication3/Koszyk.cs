using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication3
{
    class Koszyk : IKoszyk
    {
        List<Produkt> lista; 

        public Koszyk()
        {
            lista = new List<Produkt>();
        }

        public void DodajProdukt(string nazwa, double ilosc, double cenaJednostkowa)
        {
            lista.Add(new Produkt(nazwa, ilosc, cenaJednostkowa));
        }

        public void SkopiujOstatni()
        {
            try
            {
                lista.Add((Produkt)lista.Last().Clone());
            }
            catch
            {

            }
        }

        public void Skasuj(int id)
        {
            lista.RemoveAt(id);
        }

        public void Wydrukuj()
        {
            
                StreamWriter plik = new StreamWriter(DateTime.Now.ToString()+".txt");

            foreach(Produkt p in lista)
            {
                plik.WriteLine(p.ToString());
            }
            plik.Close();
        }

        public void Wyczysc()
        {
            lista.Clear();
        }

        public string PodajZawartosc()
        {
            if(lista.Count==0)
            {
                return "Koszyk jest pusty";
            }

            string zawartosc = string.Empty;

            double suma = 0;
            foreach(Produkt p in lista)
            {
                suma += p.PodajCeneLaczna();
                zawartosc += (p.ToString() + '\n');
            }
            return zawartosc +"Suma"+suma.ToString("0.00");
        }
    }
}
