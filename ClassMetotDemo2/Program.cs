using System;
using System.Collections.Generic;

namespace ClassMetotDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            MusteriManager musteriManager = new MusteriManager();
            Musteri musteri1 = musteriManager.musteriEkle("Yağız", "Gokkilic", 123456, 2000.50);
            Musteri musteri2 = musteriManager.musteriEkle("Robert", "Jackson", 234567, 1000000.80);
            
            
            
            Console.WriteLine(".............................................");
            List<Musteri> musteriler = new List<Musteri>(){ musteri1, musteri2 };
            
            musteriManager.musteriListele(musteriler);

            Console.WriteLine(".............................................");
            
            musteriManager.musteriSil(musteriler, 123456);
            musteriManager.musteriListele(musteriler);
        }
    }
}