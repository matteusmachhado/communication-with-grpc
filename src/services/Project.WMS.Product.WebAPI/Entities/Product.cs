﻿using Projetct.WMS.Core.DomainObjects;

namespace Project.WMS.Product.WebAPI.Entities
{
    public class Product : Entity
    {
        public Product(string name,
            string description,
            decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
            Created = DateTime.UtcNow;
        }

        private Product() { }

        public string Name { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
        public decimal Price { get; private set; }
        public DateTime Created { get; private set; }
        public DateTime? Disabled { get; private set; }

        public void Update(string name,
            string descrption,
            decimal price)
        {
            Name = name;
            Description = descrption;
            Price = price;
        }

        public void Disable()
        { 
            Disabled = DateTime.UtcNow;
        }
    }
}
