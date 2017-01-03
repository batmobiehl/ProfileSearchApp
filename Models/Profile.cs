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
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Display(Name = "Username")]
        public string userName { get; set; }
        [Display(Name = "Street")]
        public string street { get; set; }
        [Display(Name = "City")]
        public string city { get; set; }
        [Display(Name = "State")]
        public string state { get; set; }
        [Display(Name = "Zipcode")]
        public string zipcode { get; set; }
        [Display(Name = "Profile Picture")]
        public string profilePicture { get; set; }
    }
    public class ProfileDbContext : DbContext 
    {
        public DbSet<Profile> Profiles { get; set; }
    }
}