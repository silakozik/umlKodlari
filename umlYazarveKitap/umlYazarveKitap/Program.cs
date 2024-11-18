using System;
using System.Collections.Generic;

namespace umlYazarveKitap
{
    public class Yazar
    {
        public string Ad { get; set; }
        public string Ulke { get; set; }
        public List<Kitap> Kitaplar { get; set; }

        public Yazar()
        {
            Kitaplar = new List<Kitap>();
        }

        public void KitapEkle(Kitap kitap)
        {
            Kitaplar.Add(kitap);
        }
    }

    public class Kitap
    {
        public string Baslik { get; set; }
        public string ISBN { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Yazar oluştur
            Yazar yazar = new Yazar
            {
                Ad = "Orhan Pamuk",
                Ulke = "Türkiye"
            };

            // Kitaplar ekle
            yazar.KitapEkle(new Kitap { Baslik = "Kar", ISBN = "1234567890" });
            yazar.KitapEkle(new Kitap { Baslik = "Benim Adım Kırmızı", ISBN = "0987654321" });

            // Yazar bilgilerini yazdır
            Console.WriteLine($"Yazar: {yazar.Ad}, Ülke: {yazar.Ulke}");
            Console.WriteLine("Kitaplar:");
            foreach (var kitap in yazar.Kitaplar)
            {
                Console.WriteLine($"- {kitap.Baslik} (ISBN: {kitap.ISBN})");
            }
            Console.ReadLine();
        }
    }
}
