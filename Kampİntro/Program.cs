using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori Sayısı: ";
            long numara = 10000000000000000;
            double katsayı = 0.5;
            bool isMale = false;

            double dolarDun = 7.35;
            double dolarBugun = 8;


            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalma");
            }else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış");
            }
            else
            {
                Console.WriteLine("Aynı");
            }
            
            
            
            if (isMale)
            {
                Console.WriteLine("You are male!");
            }
            else
            {
                Console.WriteLine("You are female!");
            }

            
            Console.WriteLine(kategoriEtiketi + numara * katsayı );
            Console.WriteLine(isMale);
        }
    }
}