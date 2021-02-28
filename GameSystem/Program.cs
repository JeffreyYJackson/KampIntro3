using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace GameSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { CustomerId = 1, FirstName = "Jeffrey", LastName = "Jackson", NickName = "CoolNick", BirthDate = new DateTime(2004, 09,14),NationalityId = "12345678910"};

            Game game1 = new Game(){GameId = 1, Name = "Cs:Go", Cost = 24.0};
            Game game2 = new Game(){GameId = 2, Name = "Pubg", Cost = 70.0};
            Game game3 = new Game(){GameId = 3, Name = "Stardew Valley", Cost = 18.0};

            Sale sale1 = new Sale() {SaleID = 1, SaleName = "Winter Sales", SalePercentage = 20};


            SalesManager salesManager = new SalesManager();
            
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);

            
            GameManager gameManager = new GameManager();

            List<Game> games = new List<Game>()
            {
                game1,
                game2,
                game3

            };

            
            Console.WriteLine("------------------------------------");
            
            gameManager.Buy(games, customer1, sale1);
            Console.WriteLine("------------------------------------");
            customerManager.ListGames(customer1);

        }
    }
}