﻿namespace CoreAngularApp.Models.Domain
{
    public class Contact
    {
        public Guid ID { get; set; }
        public required string Name { get; set; }
        public string? Email { get; set; }
        public required string Phone { get; set; }
        public bool Favorite { get; set; }
    }
}
