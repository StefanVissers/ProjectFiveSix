using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ProjectFiveSix.Models
{
    public class Customer
    {
        [Key]
        public int id { get; set; }
        public String name { get; set; }
        public String surname { get; set; }
        public String email { get; set; }
        public String password { get; set; }
        public String dob { get; set; }
        public String phone_number { get; set; }
    }

    public class CustomerDBContext : DbContext
    {
        public DbSet<Customer> customers { get; set; }
    }
}