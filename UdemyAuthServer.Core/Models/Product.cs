using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyAuthServer.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Decimal Price { get; set; }
        public int Stock { get; set; }
        public string UserId { get; set; }
    }
}