using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlSirketveCalisan
{
    public class Sirket
    {
        public string Ad { get; set; }
        public string Konum { get; set; }
        public List<Calisan> Calisanlar { get; set; }

        public Sirket()
        {
            Calisanlar = new List<Calisan>();
        }

        public void CalisanEkle(Calisan calisan)
        {
            Calisanlar.Add(calisan);
            calisan.SirketAtama(this);
        }
    }

    public class Calisan
    {
        public string Ad { get; set; }
        public string Pozisyon { get; set; }
        public Sirket Sirket { get; set; }

        public void SirketAtama(Sirket sirket)
        {
            Sirket = sirket;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Şirket oluştur
            Sirket sirket = new Sirket
            {
                Ad = "Epic Games",
                Konum = "Cary, North Carolina, USA"
            };

            // Çalışan oluştur
            Calisan calisan = new Calisan
            {
                Ad = "Sıla",
                Pozisyon = "Oyun Geliştirici"
            };

            // Çalışanı şirkete ekle
            sirket.CalisanEkle(calisan);

            // Çıktı
            Console.WriteLine($"Şirket: {sirket.Ad}, Konum: {sirket.Konum}");
            Console.WriteLine("Çalışanlar:");
            foreach (var emp in sirket.Calisanlar)
            {
                Console.WriteLine($"- Ad: {emp.Ad}, Pozisyon: {emp.Pozisyon}");
            }

            // Konsolun kapanmaması için
            Console.ReadLine();
        }
    }

}
