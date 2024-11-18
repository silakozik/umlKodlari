using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlOtomobilveMotor
{
    class Motor
    {
        public int Guc { get; set; } // Beygir gücü
        public string Tip { get; set; }

        public void MotorBilgisi()
        {
            Console.WriteLine($"Motor Gücü: {Guc} HP, Tip: {Tip}");
        }
    }

    class Otomobil
    {
        public string Marka { get; set; }
        public Motor Motor { get; set; }

        public void MotorOlustur(int guc, string tip)
        {
            Motor = new Motor
            {
                Guc = guc,
                Tip = tip
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Otomobil otomobil = new Otomobil { Marka = "Toyota" };
            otomobil.MotorOlustur(150, "Benzinli");

            Console.WriteLine($"Otomobil Markası: {otomobil.Marka}");
            otomobil.Motor.MotorBilgisi();

            Console.ReadLine();
        }
    }

}
