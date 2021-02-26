using System;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Product urun)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi: " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi: " + urunAdi);
        }
    }
}