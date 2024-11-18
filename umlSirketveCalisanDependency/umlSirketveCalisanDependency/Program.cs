using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlSirketveCalisanDependency
{
    class Calisan
    {
        public string Ad { get; set; }
        public string Pozisyon { get; set; }

        public void CalisanBilgisi()
        {
            Console.WriteLine($"Ad: {Ad}, Pozisyon: {Pozisyon}");
        }
    }

    class Sirket
    {
        public string Ad { get; set; }
        public List<Calisan> Calisanlar { get; set; }

        public Sirket()
        {
            Calisanlar = new List<Calisan>();
        }

        public void CalisanEkle(Calisan calisan)
        {
            Calisanlar.Add(calisan);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sirket sirket = new Sirket { Ad = "SSS" };

            Calisan calisan1 = new Calisan { Ad = "Sena", Pozisyon = "Yazılım Geliştirici" };
            Calisan calisan2 = new Calisan { Ad = "Seher", Pozisyon = "Proje Yöneticisi" };

            sirket.CalisanEkle(calisan1);
            sirket.CalisanEkle(calisan2);

            Console.WriteLine($"Şirket adı: {sirket.Ad}");
            foreach (var calisan in sirket.Calisanlar)
            {
                calisan.CalisanBilgisi();
            }
            Console.ReadLine();
        }
    }

}
