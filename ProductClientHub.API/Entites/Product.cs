﻿namespace ProductClientHub.API.Entites
{
    public class Product : EntityBase
    {

        public string Name { get; set; } = string.Empty;

        public string Brand { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public Guid ClientId { get; set; }


    }
}
