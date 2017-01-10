using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication3
{
    interface IKoszyk
    {
        void DodajProdukt(string nazwa, double ilosc, double cenaJednostkowa);
        void SkopiujOstatni();
        void Skasuj(int id);
        void Wydrukuj();
        void Wyczysc();
        string PodajZawartosc();
    }
}
