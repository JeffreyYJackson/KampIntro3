using System;

namespace Strubucks
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 1,FirstName = "Jeffey", LastName = "Jackson", NationalityId = "12345678910",DateOfBirth = new DateTime(2004, 09, 14)
            };
            
            
            
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(customer1);
        }
    }
}