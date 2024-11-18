using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlMusteriveSiparis
{
    public class Musteri
    {
        public string Ad { get; set; }
        public string Telefon { get; set; }

        public void SiparisVer(Siparis siparis)
        {
            // Sipariş verme işlemi burada gerçekleştirilebilir
            Console.WriteLine($"Müşteri {Ad} yeni bir sipariş verdi.");
            Console.WriteLine($"Sipariş Tarihi: {siparis.Tarih}");
            Console.WriteLine($"Sipariş Durumu: {siparis.Durum}");
        }
    }

    public class Siparis
    {
        public DateTime Tarih { get; set; }
        public string Durum { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Müşteri oluştur
            Musteri musteri = new Musteri
            {
                Ad = "Kayra",
                Telefon = "0555 555 5555"
            };

            // Sipariş oluştur
            Siparis siparis = new Siparis
            {
                Tarih = DateTime.Now,
                Durum = "Hazırlanıyor"
            };

            // Siparişi işleme al
            musteri.SiparisVer(siparis);

            // Konsolun kapanmaması için
            Console.ReadLine();
        }
    }

}
