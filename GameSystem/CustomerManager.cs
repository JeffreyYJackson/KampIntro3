using System;

namespace GameSystem
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            if (new PersonCheckManager().CheckIfValidCustomer())
            {
                Console.WriteLine("Customer " + customer.NickName + " added");
            }
            else
            {
                throw new Exception("Not a valid customer");
            }

        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Customer " + customer.NickName + " updated");
        }

        public void Remove(Customer customer)
        {
            Console.WriteLine("Customer " + customer.NickName + " removed");
        }

        public void ListGames(Customer customer)
        {
            foreach (Game game in customer.Games)
            {
                Console.WriteLine(game.Name);
            }
        }
    }
}