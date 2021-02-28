using System;

namespace Strubucks
{
    public class StarbucksCUstomerManager:BaseCustomerManager
    {
        private IPersonCheckService _personCheckService;

        public StarbucksCUstomerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_personCheckService.CheckIfRealPerson(customer) )
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid customer");
            }
            
            
        }

        
    }
}