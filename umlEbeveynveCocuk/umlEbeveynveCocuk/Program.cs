using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlEbeveynveCocuk
{
    public class Ebeveyn
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public List<Cocuk> Cocuklar { get; set; }

        public Ebeveyn()
        {
            Cocuklar = new List<Cocuk>();
        }

        public void CocukEkle(Cocuk cocuk)
        {
            Cocuklar.Add(cocuk);
            cocuk.EbeveynAtama(this);
        }
    }

    public class Cocuk
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public Ebeveyn Ebeveyn { get; set; }

        public void EbeveynAtama(Ebeveyn ebeveyn)
        {
            Ebeveyn = ebeveyn;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Ebeveyn oluştur
            Ebeveyn ebeveyn = new Ebeveyn
            {
                Ad = "Ebru",
                Yas = 43
            };

            // Çocukları oluştur
            Cocuk cocuk1 = new Cocuk { Ad = "Sıla", Yas = 20 };
            Cocuk cocuk2 = new Cocuk { Ad = "Kayra", Yas = 16 };
            Cocuk cocuk3 = new Cocuk { Ad = "Fatma", Yas = 7 };

            // Çocukları ebeveyne ekle
            ebeveyn.CocukEkle(cocuk1);
            ebeveyn.CocukEkle(cocuk2);
            ebeveyn.CocukEkle(cocuk3);

            // Çıktı
            Console.WriteLine($"Ebeveyn: {ebeveyn.Ad}, Yaş: {ebeveyn.Yas}");
            Console.WriteLine("Çocuklar:");
            foreach (var cocuk in ebeveyn.Cocuklar)
            {
                Console.WriteLine($"- Ad: {cocuk.Ad}, Yaş: {cocuk.Yas}");
            }

            // Konsolun kapanmaması için
            Console.ReadLine();
        }
    }

}
