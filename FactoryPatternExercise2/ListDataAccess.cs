using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    class ListDataAccess : IDataAccess
    {
        List<Product> Pokemon = new List<Product>()
        {
            new Product() {Name = "Giratina V #186", Price = 408.97m},
            new Product() {Name = "Aerodactyl v #180", Price = 98.23m},
            new Product() {Name = "Pikachu VMAX #TG29", Price = 6.99m},
            new Product() {Name = "Charizard #TG03", Price = 4.26m},
            new Product() {Name = "Mew VMAX #TG30", Price = 6.34m},
            new Product() {Name = "Pikachu VMAX #TG17", Price = 38.29m},
            new Product() {Name = "Gengar #TG06", Price = 5.50m}
        };

        
        public List<Product> LoadData()
        {
            Console.WriteLine($"I am loading your Pokemon cards from the List Database");
            return Pokemon;
        }


        public void SaveData(List<Product> Pokemon)
        {
            Console.WriteLine("Saving your Pokemon cards to List Database....");
        }
    }
}
