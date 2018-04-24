using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Product
    {
        private int recNumber;
        private int id;
        private string name;
        private string description;
        private double price;

        public Product()
        {
            this.RecNumber = 0;
            this.Id = 0;
            this.Name = "";
            this.Description = "";
            this.Price = 0;
        }

        public Product(int recNumber, int id, string name, string description, double price)
        {
            this.RecNumber = recNumber;
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }

        public int RecNumber { get => recNumber; set => recNumber = value; }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }

        public override string ToString()
        {
            return $"{recNumber} {Id} {Name} {Description} {Price}";
        }
    }
}