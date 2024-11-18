using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlBilgisayarveİslemci
{
    class Islemci
    {
        public int Cekirdekler { get; set; }
        public int Frekans { get; set; }

        public void IslemciBilgisi()
        {
            Console.WriteLine($"Çekirdek Sayısı: {Cekirdekler}, Frekans: {Frekans} MHz");
        }
    }

    class Bilgisayar
    {
        public string Model { get; set; }
        public Islemci Islemci { get; set; }

        public void IslemciOlustur(int cekirdekler, int frekans)
        {
            Islemci = new Islemci
            {
                Cekirdekler = cekirdekler,
                Frekans = frekans
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar bilgisayar = new Bilgisayar { Model = "Asus ROG" };
            bilgisayar.IslemciOlustur(8, 3200);

            Console.WriteLine($"Bilgisayar Modeli: {bilgisayar.Model}");
            bilgisayar.Islemci.IslemciBilgisi();

            Console.ReadLine();
        }
    }

}
