using System;

namespace OOP3
{
    public class IhtiyacKrediManager:IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme Planı Hesaplandı");
        }

        public void BiseyYap()
        {
            throw new System.NotImplementedException();
        }
    }
}