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
            CheckIfRealPerson(customer);
            base.Save(customer);
        }

        private void CheckIfRealPerson(Customer customer)
        {
            
        }
    }
}