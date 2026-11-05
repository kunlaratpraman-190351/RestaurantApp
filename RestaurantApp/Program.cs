using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello SIT.1/1");
            Console.WriteLine("Hello jaaaa");
            Console.WriteLine("Week 2");

            List<Restaurant> restaurants = new List<Restaurant>
            {
                new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
                new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
                new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7),
                new Restaurant(4, "Huguosi Snacks", "Snacks", 4.2),
                new Restaurant(5, "Haidilao Hot Pot", "Hot Pot", 4.8),
            };

            Console.WriteLine("--- Restaurant List ---");
            foreach (var item in restaurants)
            {
                Console.WriteLine($"ID: {item.Id} | Name: {item.Name} | Type: {item.Type} | Rating: {item.Rating}");
            }

            // คำนวณจำนวนร้านและคะแนนเฉลี่ย
            int totalCount = restaurants.Count;
            double avgRating = restaurants.Average(r => r.Rating);

            Console.WriteLine("-----------------------");
            Console.WriteLine($"Total Restaurants: {totalCount}");
            Console.WriteLine($"Average Rating: {avgRating:F2}");


        }
    }

    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rating { get; set; }

        public Restaurant(int id,string name,string type, double rating)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Rating = rating;
        }

    }


}
