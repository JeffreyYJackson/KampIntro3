using System;

namespace OOP3
{
    public class TasitKrediManager:IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Taşıt Kredisi Ödeme Planı Hesaplandı.");
        }

        public void BiseyYap()
        {
            throw new System.NotImplementedException();
        }
    }
}