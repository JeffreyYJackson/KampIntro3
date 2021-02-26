using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursEgitmeni = "Engin";
            kurs1.IzlemeOrani = 68;
            
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursEgitmeni = "Engin";
            kurs2.IzlemeOrani = 28;
            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.KursEgitmeni + " " + kurs1.IzlemeOrani);
            
            Kurs[] kurslar = new Kurs[]{kurs1, kurs2 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int IzlemeOrani { get; set; }
    }
}