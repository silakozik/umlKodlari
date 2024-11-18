using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlUrunveSiparis
{
    public class Urun
    {
        public string Ad { get; set; }
        public int Fiyat { get; set; }

        public string UrunBilgisi()
        {
            return $"{Ad}, Fiyat: {Fiyat} TL";
        }
    }

    public class Siparis
    {
        public DateTime Tarih { get; set; }
        public decimal Toplam { get; set; }
        public List<Urun> Urunler { get; set; }

        public Siparis()
        {
            Urunler = new List<Urun>();
        }

        public void UrunEkle(Urun urun)
        {
            Urunler.Add(urun);
            Toplam += urun.Fiyat;
        }

        public void SiparisBilgisiYazdir()
        {
            Console.WriteLine($"Sipariş Tarihi: {Tarih}");
            Console.WriteLine($"Sipariş Toplamı: {Toplam} TL");
            Console.WriteLine("Sipariş Edilen Ürünler:");
            foreach (var urun in Urunler)
            {
                Console.WriteLine($"- {urun.UrunBilgisi()}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Ürünler oluştur
            Urun urun1 = new Urun { Ad = "Laptop", Fiyat = 15000 };
            Urun urun2 = new Urun { Ad = "Mouse", Fiyat = 500 };

            // Sipariş oluştur
            Siparis siparis = new Siparis
            {
                Tarih = DateTime.Now
            };

            // Ürünleri siparişe ekle
            siparis.UrunEkle(urun1);
            siparis.UrunEkle(urun2);

            // Sipariş bilgilerini yazdır
            siparis.SiparisBilgisiYazdir();

            // Konsolun kapanmaması için
            Console.ReadLine();
        }
    }

}
