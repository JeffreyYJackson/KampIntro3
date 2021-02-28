namespace Strubucks
{
    public class PersonCheckManager:IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}