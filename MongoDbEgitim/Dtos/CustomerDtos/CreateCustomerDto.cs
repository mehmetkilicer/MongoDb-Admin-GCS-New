﻿using MongoDbEgitim.Entities;

namespace MongoDbEgitim.Dtos.CustomerDtos
{
    public class CreateCustomerDto
    {
        public string CustomerFullName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone { get; set; }
        public List<Order> Orders { get; set; }
    }
}