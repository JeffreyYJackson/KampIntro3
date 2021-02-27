using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNUm = "12345";
            customer1.Name = "Jeff";
            customer1.Surname = "Jackson";
            customer1.TcNo = "12345678910";




            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNUm = "54321";
            customer2.CompanyName = "Lenovo";
            customer2.TaxNum = "1234567890";




            CUstomer customer3 = new IndividualCustomer();
            CUstomer customer4 = new CorporateCustomer();
        }
    }
}