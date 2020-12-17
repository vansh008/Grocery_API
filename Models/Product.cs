using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Grocery_API.Models
{
    public class Product
    {
        [Key]
        public int Product_ID { get; set; }

        public string Product_Name { get; set; }

        public string Product_category { get; set; }

        public string Product_expire { get; set; }

        public string Product_price { get; set; }
    }
}
