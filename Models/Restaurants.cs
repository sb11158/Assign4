using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assign4.Models
{
    public class Restaurants
    {
        //constructor
        public Restaurants(int rank)
        {
            Ranking = rank;
        }
        //declare model attributes
        [Required]
        public int Ranking { get;}
        [Required]
        public string Name { get; set; }
        public string? FavDish { get; set; } = "It's all tasty";
        [Required]
        public string Address { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public string? Website { get; set; } = "Coming Soon!";

       
        public static Restaurants[] GetRestaurant()
        {
            //declare top 5 restaurants
            Restaurants b1 = new Restaurants(1)
            {
                Name = "Midicis",
                FavDish = "Magarita Pizza",
                Address = "1234 University Parkway, Orem",
                Phone = "123-345-5678",
                Website = "https://mymidici.com/stores/utah/orem/orem/"
            };
            Restaurants b2 = new Restaurants(2)
            {
                Name = "Chipotle",
                FavDish = "Chicken Tacos",
                Address = "0001 University Parkway, Orem",
                Phone = "123-345-5678",
                Website = "https://www.chipotle.com/"
            };
            Restaurants b3 = new Restaurants(3)
            {
                Name = "Chickfila",
                Address = "1111 Cougar Blvd",
                Phone = "123-345-5678",
                Website = "https://www.chick-fil-a.com/"
            };
            Restaurants b4= new Restaurants(4)
            {
                Name = "Vessel Kitchen",
                FavDish = "Steelhead Trout",
                Address = "Park City Utah",
                Phone = "123-345-5678",
                Website = "https://www.vesselkitchen.com/"

            };
            Restaurants b5 = new Restaurants(5)
            {
                Name = "Thai So Good",
                FavDish = "Massama Curry",
                Address = "Kimball Junction, Park City",
                Phone = "123-345-5678",
                Website = "https://www.thaisogoodatkimball.com/"

            };
            //return restaurants
            return new Restaurants[] { b1, b2, b3, b4, b5  };
        }
    }
}
