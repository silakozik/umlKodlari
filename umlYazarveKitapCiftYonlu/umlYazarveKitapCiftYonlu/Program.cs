using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlYazarveKitapCiftYonlu
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
            kitap.YazarAtama(this);
        }
    }

    public class Kitap
    {
        public string Baslik { get; set; }
        public DateTime YayinTarihi { get; set; }
        public Yazar Yazar { get; set; }

        public void YazarAtama(Yazar yazar)
        {
            Yazar = yazar;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Yazar oluştur
            Yazar yazar = new Yazar
            {
                Ad = "Zülfü Livaneli",
                Ulke = "Türkiye"
            };

            // Kitapları oluştur ve ekle
            Kitap kitap1 = new Kitap
            {
                Baslik = "Kardeşimin Hikayesi",
                YayinTarihi = new DateTime(2013, 4, 1) // Yayın tarihi
            };

            Kitap kitap2 = new Kitap
            {
                Baslik = "Bab-ı Esrar",
                YayinTarihi = new DateTime(2008, 9, 15) // Yayın tarihi
            };

            yazar.KitapEkle(kitap1);
            yazar.KitapEkle(kitap2);

            // Çıktı
            Console.WriteLine($"Yazar: {yazar.Ad}, Ülke: {yazar.Ulke}");
            Console.WriteLine("Kitapları:");
            foreach (var kitap in yazar.Kitaplar)
            {
                Console.WriteLine($"- {kitap.Baslik}, Yayın Tarihi: {kitap.YayinTarihi.ToShortDateString()}");
            }

            // Konsolun kapanmaması için
            Console.ReadLine();
        }
    }

}
