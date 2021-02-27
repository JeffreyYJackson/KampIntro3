using System;

namespace OOP3
{
    public class KonutKrediManager:IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Konut Kredisi Ödeme Planı Hesaplandı");
        }

        public void BiseyYap()
        {
            throw new System.NotImplementedException();
        }
    }
}