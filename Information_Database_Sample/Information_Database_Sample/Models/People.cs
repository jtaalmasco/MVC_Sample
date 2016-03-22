using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace People_Information.Models
{
    public class People
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [DisplayName("First Name")]
        public string FName { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [DisplayName("Last Name")]
        public string LName { get; set; }
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
    }

    public class PeopleDBContext : DbContext
    {
        public DbSet<People> PeopleA { get; set; }
    }
}