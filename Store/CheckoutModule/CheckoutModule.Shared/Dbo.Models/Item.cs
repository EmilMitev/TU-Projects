﻿
namespace Store.Models
{
    using SQLite;

    public class Item
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string Measurement { get; set; }

        public byte[] Image { get; set; }

        public string Tempimage { get; set; } = "http://simpleicon.com/wp-content/uploads/mobile-1.png";

        public int CategoryId { get; set; }
    }
}