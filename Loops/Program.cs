using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[]
            {
                "1. Kurs",
                "2. Kurs", 
                "3. Kurs",
                "4. Kurs"
            };
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}