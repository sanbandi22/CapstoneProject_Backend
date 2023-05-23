﻿namespace CapstoneProject_Backend.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }
        public int UserId { get; set; }
    }
}
