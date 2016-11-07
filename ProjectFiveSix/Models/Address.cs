using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectFiveSix.Models
{
    public class Address
    {
        public String postal_code { get; set; }
        public String country { get; set; }
        public int house_number { get; set; }
        public String city { get; set; }
        public String province { get; set; }
        public String street { get; set; }
    }
}