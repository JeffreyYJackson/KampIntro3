using System;
using System.Collections.Generic;

namespace GameSystem
{
    public class SalesManager
    {
        public void Add()
        {
            Console.WriteLine("Sale added");
        }
        

        public void Update()
        {
            Console.WriteLine("Sale updated");
        }

        public void Remove()
        {
            Console.WriteLine("Sale removed");
        }

        public double CalculateTotalSale(Sale sale, List<Game> games)
        {
            double total = 0;
            foreach (Game game in games)
            {
                total += game.Cost;
            }

            return total * sale.SalePercentage / 100;
        }
    }
}