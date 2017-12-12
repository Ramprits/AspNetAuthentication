using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetAuthentication.Models {
    public class Session {

        [Key]
        public Guid SessionId { get; set; }
        public string Name { get; set; }
        public string Presenter { get; set; }
        public int Duration { get; set; }
        public string Level { get; set; }
        public string Abstract { get; set; }
        public string Voters { get; set; }
    }
}