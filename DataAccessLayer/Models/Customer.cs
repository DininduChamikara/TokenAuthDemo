﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Id { get; set; }
        public int Index { get; set; }
        public int Age { get; set; }
        public string? EyeColor { get; set; }
        public string Name { get; set; }
        public string? Gender { get; set; }
        public string? Company { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Address? Address { get; set; }
        public string? About { get; set; }
        public string? Registered { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
