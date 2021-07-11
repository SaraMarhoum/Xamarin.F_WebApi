using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace XamarinFApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

    }
}
