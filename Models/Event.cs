using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetAuthentication.Models {
    public class Event {

        [Key]
        public Guid EventId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int price { get; set; }
        public string ImageUrl { get; set; }
        public string OnlineUrl { get; set; }
        public Location Location { get; set; }
        public ICollection<Session> Sessions { get; set; }

    }

    public class Location {

        [Key]
        public Guid LocationId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}