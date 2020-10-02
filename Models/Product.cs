using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace beshishop.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductID { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }
        public string Category { get; set; }
        public string Details { get; set; }
        public string Photo { get; set; }
        public string BrandTitle { get; set; }

        public string BrandID { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int Rates { get; set; }

        public double Rating { get; set; }

        public bool Featured { get; set; }
        public bool Liked { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        
    }
}