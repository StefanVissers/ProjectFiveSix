using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectFiveSix.Models
{
    public class customer
    {
        public int customer_id { get; set; }
        public String name { get; set; }
        public String surname { get; set; }
        public String email { get; set; }
        public String password { get; set; }
        public String dob { get; set; }
        public String phone_number { get; set; }
    }
}