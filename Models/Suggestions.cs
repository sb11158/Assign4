using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assign4.Models
{
    public class Suggestions
    {
        //declare model attributes 
        public string? Name { get; set; } = "Jane Doe";
        [Required]
        public string RestaurantName { get; set; }
        public string? FavDish { get; set; } = "It's all tasty";
        [DataType(DataType.PhoneNumber)]
        //[RegularExpression("^((\+\d{1,2}|1)[\s.-]?)?\(?[2-9](?!11)\d{2}\)?[\s.-]?\d{3}[\s.-]?\d{4}$")]
        public string Phone { get; set; }
        
    }
}
