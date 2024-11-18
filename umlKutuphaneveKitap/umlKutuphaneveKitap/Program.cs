using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlKutuphaneveKitap
{
    class Kitap
    {
        public string Baslik { get; set; }
        public string Yazar { get; set; }
    }

    class Kutuphane
    {
        public string Ad { get; set; }
        public List<Kitap> Kitaplar { get; set; }

        public Kutuphane()
        {
            Kitaplar = new List<Kitap>();
        }

        public void KitapEkle(Kitap kitap)
        {
            Kitaplar.Add(kitap);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kutuphane kutuphane = new Kutuphane { Ad = "Merkez Kütüphane" };

            Kitap kitap1 = new Kitap { Baslik = "Notre Dame'ın Kamburu", Yazar = "Victor Hugo" };
            Kitap kitap2 = new Kitap { Baslik = "Kürk Mantolu Madonna ", Yazar = "Sabahattin Ali" };
            Kitap kitap3 = new Kitap { Baslik = "Kızım Olmadan Asla ", Yazar = "Betty Mahmudi" };

            kutuphane.KitapEkle(kitap1);
            kutuphane.KitapEkle(kitap2);
            kutuphane.KitapEkle(kitap3);

            Console.WriteLine($"Kütüphane adı: {kutuphane.Ad}");
            foreach (var kitap in kutuphane.Kitaplar)
            {
                Console.WriteLine($"Kitap Başlığı: {kitap.Baslik}, Yazar: {kitap.Yazar}");
            }
            Console.ReadLine();
        }
    }

}
