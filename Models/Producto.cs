using System;
using System.Collections.Generic;
using System.Text;

namespace TrabajoPractico4JoaquinSeitz.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public string? Image { get; set; }
    }
}