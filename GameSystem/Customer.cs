using System;
using System.Collections.Generic;

namespace GameSystem
{
    public class Customer
    {
        public Customer()
        {
            Games = new List<Game>();
        }
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string NationalityId { get; set; }
        public DateTime BirthDate { get; set; }
        
        public List<Game> Games { get;}
    }
}