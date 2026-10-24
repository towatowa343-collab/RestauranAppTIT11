using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranApp
{
    public class Restaurant 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string type { get; set; }
        public double Rating { get; set; }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Restaurant> restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Quanjude Roast Duck",type ="Beijing Cuisine" , Rating = 4.5 },
                new Restaurant { Id = 2, Name = "Donglaishun Hot Pot",type ="Hot Pot" , Rating = 4.6 },
                new Restaurant { Id = 3, Name = "Din Tai Fung",type ="Taiwanese Cuisine" , Rating = 4.7 },
                new Restaurant { Id = 4, Name = "Huguosi Snacks",type ="Snacks" , Rating = 4.2 },
                new Restaurant { Id = 5, Name = "Haidilao Hot Pot",type ="Hot Pot" , Rating = 4.8 },
            };
            Console.WriteLine("===ราชื่อร้านอาหารทั้งหมด===");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine($"{"ID",-5} {"Name",-25} {"Type",-20} {"Rating",-6} ");
            Console.WriteLine("--------------------------------------------------------------");

            foreach (var r in restaurants)
            {
                Console.WriteLine($"{r.Id,-5} {r.Name,-25} {r.type,-20} {r.Rating,-6} ");

            }
            Console.WriteLine("--------------------------------------------------------------");
            int toralrestaurants = restaurants.Count;
            Double averageRating = restaurants.Average(r => r.Rating);
        }
    }
}