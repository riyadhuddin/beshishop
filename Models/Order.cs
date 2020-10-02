using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace beshishop.Models
{
    public class Order
    {
        public string OrderID { get; set; }
        public string ProductID { get; set; }
        public string BrandID { get; set; }

        public virtual Product Product { get; set; }
    }
}