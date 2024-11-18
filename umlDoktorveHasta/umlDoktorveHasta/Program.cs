using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlDoktorveHasta
{
    public class Doktor
    {
        public string Ad { get; set; }
        public string Brans { get; set; }
        public List<Hasta> Hastalar { get; set; }

        public Doktor()
        {
            Hastalar = new List<Hasta>();
        }

        public void HastaEkle(Hasta hasta)
        {
            Hastalar.Add(hasta);
            hasta.DoktorAtama(this);
        }
    }

    public class Hasta
    {
        public string Ad { get; set; }
        public string TCNo { get; set; }
        public Doktor Doktor { get; set; }

        public void DoktorAtama(Doktor doktor)
        {
            Doktor = doktor;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Doktor oluştur
            Doktor doktor = new Doktor
            {
                Ad = "Dr. Mehmet Yılmaz",
                Brans = "Kardiyoloji"
            };

            // Hasta oluştur
            Hasta hasta1 = new Hasta
            {
                Ad = "Ayşe Demir",
                TCNo = "12345678901"
            };

            Hasta hasta2 = new Hasta
            {
                Ad = "Ali Çelik",
                TCNo = "98765432100"
            };

            // Hastaları doktora ekle
            doktor.HastaEkle(hasta1);
            doktor.HastaEkle(hasta2);

            // Çıktı
            Console.WriteLine($"Doktor: {doktor.Ad}, Branş: {doktor.Brans}");
            Console.WriteLine("Hastalar:");
            foreach (var hasta in doktor.Hastalar)
            {
                Console.WriteLine($"- {hasta.Ad}, TC No: {hasta.TCNo}");
            }

            // Konsolun kapanmaması için
            Console.ReadLine();
        }
    }

}
