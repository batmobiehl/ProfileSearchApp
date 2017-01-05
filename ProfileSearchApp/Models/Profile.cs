using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProfileSearchApp.Models
{
    public class Profile
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Required]
        [Display(Name = "Username")]
        public string userName { get; set; }
        [Required]
        [Display(Name = "Street")]
        public string street { get; set; }
        [Required]
        [Display(Name = "City")]
        public string city { get; set; }
        [Required]
        [StringLength(2)]
        [Display(Name = "State")]
        public string state { get; set; }
        [Required]
        [StringLength(5)]
        [Display(Name = "Zipcode")]
        public string zipcode { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public string phoneNumber { get; set; }
        [Required]
        [Display(Name = "Profile Picture")]
        public string profilePicture { get; set; }
    }
    public class ProfileDbContext : DbContext 
    {
        public DbSet<Profile> Profiles { get; set; }
    }
}