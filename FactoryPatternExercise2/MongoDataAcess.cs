using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class MongoDataAcess : IDataAccess
    {
        List<Product> MTG = new List<Product>() {
                new Product() { Name = "Ash Blosson & Joyous Spring [Quater Century Secret Rare] RA01-EN008)", Price = 165.66m},
                new Product() { Name = "Masked HERO Dark Law [Misprint] RA01-EN025", Price = 100.00m},
                new Product() { Name = "Infinite Impermanence [Quater Century Secret Rare] RA01-EN075", Price = 75.00m},
                new Product() { Name = "Ash Blossom & Joyous Spring [Collector's Rare] RA01=EN008", Price = 22.67m},
                new Product() { Name = "Effect Veiler [Quater Century Secret Rare] RA01-EN003", Price = 68.42m},
                new Product() { Name = "Knightmare Unicorn [Alternate Art Quater Century Secret Rare] RA01-EN043", Price = 14.97m},
                new Product() { Name = "Nibiru the Primal Being [Quater Century Secret Rare] RA01-EN015", Price = 51.54m}
                };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am loading your Magic The Gathering cards from Mongo Database ");
            return MTG;
        }

        public void SaveData(List<Product> products)
        {
            Console.WriteLine("Saving you Magic The Gathering cards to the Mongo Database...");
        }
    }
}
