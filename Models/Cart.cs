using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace beshishop.Models
{
    public class Cart
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CartID { get; set; }
        public string OrderID { get; set; }
        
        public string ProductID { get; set; }
        public string BrandID { get; set; }
        
        public int Total { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}