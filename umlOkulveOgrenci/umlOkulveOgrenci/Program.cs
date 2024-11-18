using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlOkulveOgrenci
{
    class Ogrenci
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
    }

    class Okul
    {
        public string Ad { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }

        public Okul()
        {
            Ogrenciler = new List<Ogrenci>();
        }

        public void OgrenciEkle(string ad, int yas)
        {
            Ogrenciler.Add(new Ogrenci { Ad = ad, Yas = yas });
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Okul okul = new Okul { Ad = "Anadolu Lisesi" };

            okul.OgrenciEkle("Kayra", 16);
            okul.OgrenciEkle("Mustafa", 15);

            Console.WriteLine($"Okul Adı: {okul.Ad}");
            foreach (var ogrenci in okul.Ogrenciler)
            {
                Console.WriteLine($"Öğrenci Adı: {ogrenci.Ad}, Yaş: {ogrenci.Yas}");
            }

            Console.ReadLine();
        }
    }

}
