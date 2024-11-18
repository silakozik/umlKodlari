using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlCalisanveDepartman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace umlUrunveSiparis
    {
        public class Calisan
        {
            public string Ad { get; set; }
            public string Pozisyon { get; set; }
            public Departman Departman { get; set; }

            public void DepartmanAtama(Departman departman)
            {
                Departman = departman;
            }
        }

        public class Departman
        {
            public string Ad { get; set; }
            public string Lokasyon { get; set; }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Departman oluştur
                Departman yazilimDepartmani = new Departman
                {
                    Ad = "Yazılım Geliştirme",
                    Lokasyon = "İstanbul"
                };

                // Çalışan oluştur
                Calisan calisan = new Calisan
                {
                    Ad = "Sıla",
                    Pozisyon = "Yönetici"
                };

                // Çalışanı departmana atama
                calisan.DepartmanAtama(yazilimDepartmani);

                // Çıktı
                Console.WriteLine("Çalışan Bilgileri:");
                Console.WriteLine($"Ad: {calisan.Ad}");
                Console.WriteLine($"Pozisyon: {calisan.Pozisyon}");
                Console.WriteLine($"Departman: {calisan.Departman.Ad}");
                Console.WriteLine($"Lokasyon: {calisan.Departman.Lokasyon}");

                // Konsolun kapanmaması için
                Console.ReadLine();
            }
        }
    }

}
