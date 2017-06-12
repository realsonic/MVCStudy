using System;

namespace Lesson03_Self.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}