using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlEvveOda
{
    class Oda
    {
        public string Boyut { get; set; }
        public string Tip { get; set; }
    }

    class Ev
    {
        public string Ad { get; set; }
        public List<Oda> Odalar { get; set; }

        public Ev()
        {
            Odalar = new List<Oda>();
        }

        public void OdaEkle(Oda oda)
        {
            Odalar.Add(oda);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ev ev = new Ev { Ad = "1+0 Ev" };

            Oda salon = new Oda { Boyut = "30m2", Tip = "Salon" };
            Oda mutfak = new Oda { Boyut = "15m2", Tip = "Mutfak" };

            ev.OdaEkle(salon);
            ev.OdaEkle(mutfak);

            Console.WriteLine($"Ev adı: {ev.Ad}");
            foreach (var oda in ev.Odalar)
            {
                Console.WriteLine($"Oda Tipi: {oda.Tip}, Boyut: {oda.Boyut}");
            }
            Console.ReadLine();
        }
    }

}
