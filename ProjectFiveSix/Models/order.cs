using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectFiveSix.Models
{
    public class order
    {
        public int order_id { get; set; }
        public int customer_id { get; set; }
        public String status { get; set; }

    }
}