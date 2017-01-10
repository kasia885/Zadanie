using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication3
{
    class Produkt 
    {
        private string nazwa;
        private double cenaJednostkowa;
        private double ilosc;

        public Produkt ()
        {
            nazwa = "Nieznane";
            ilosc = '0';
            cenaJednostkowa = '0';
        }

        public Produkt(string nazwa, double cenaJednostkowa, double ilosc)
        {
            this.nazwa = nazwa;
            this.cenaJednostkowa = cenaJednostkowa;
            this.ilosc = ilosc;
        }



    }
}
