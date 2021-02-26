using System;
using System.Collections.Generic;

namespace ClassMetotDemo2
{
    public class MusteriManager
    {
        public Musteri musteriEkle(string ad, string soyad, int id, double hesapPara)
        {
            Musteri x = new Musteri();
            x.KullaniciAdi = ad;
            x.KullaniciSoyadi = soyad;
            x.Id = id;
            x.HesapParaMiktar = hesapPara;
            return x;
        }

        public void musteriListele(List<Musteri> x)
        {
            foreach (Musteri musteri in x)
            {
                Console.WriteLine(musteri.KullaniciAdi + " " + musteri.KullaniciSoyadi);
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.HesapParaMiktar);
                Console.WriteLine("---------------------------------------");
            }
        }

        public void musteriSil(List<Musteri> x, int id)
        {
            
            for (var i = 0; i < x.Count; i++)
            {
                Musteri musteri = x[i];
                if (musteri.Id == id)
                {
                    x.RemoveAt(i);
                }

                
            }
        }

    }
}