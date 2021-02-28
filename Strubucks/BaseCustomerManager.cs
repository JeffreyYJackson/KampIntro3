using System;

namespace Strubucks
{
    public abstract class BaseCustomerManager:ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to Data Base: " + customer.FirstName);
        }
    }
}