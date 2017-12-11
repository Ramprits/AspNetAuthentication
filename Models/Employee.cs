using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetAuthentication.Models {
    public class Employee {

        [Key]
        public Guid EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
}