using System;
using System.Collections.Generic;

namespace GameSystem
{
    public class GameManager
    {
        public void Buy(List<Game> games, Customer customer, Sale sale)
        {
            double total = 0;

            foreach (Game game in games)
            {
                total += game.Cost;
            }
            
            
            
            foreach (Game game in games)
            {
                customer.Games.Add(game);
            }

            foreach (Game game in games)
            {
                Console.Write(game.Name + " ");
            }

            Console.WriteLine("added for " + (total - new SalesManager().CalculateTotalSale(sale, games) + " Turkish Liras."));
        }
    }
}