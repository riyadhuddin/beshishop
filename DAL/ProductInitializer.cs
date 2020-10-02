using beshishop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace beshishop.DAL
{
    public class ProductInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            //base.Seed(context);
            var products = new List<Product>
            {
                new Product
                {
                    ProductID="1",BrandID="2",Name="Samosa",Details="love spicy",
                    BrandTitle="DeshiShad",Category="Food",Price=20,Quantity=5,
                    Featured = true, Liked = true, Rates=5,Rating=4,Photo="save"
                }
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
            //code for order
            var orders = new List<Order>
            {
                new Order{OrderID="1",BrandID="2",ProductID="1"}

            };
            orders.ForEach(s => context.Orders.Add(s));
            context.SaveChanges();
            //add to cart
            var carts = new List<Cart>
            {
                new Cart{CartID="1",OrderID="1",BrandID="2",ProductID="1",Total= 3}
            };
            carts.ForEach(s => context.Carts.Add(s));
            context.SaveChanges();
            //add brand
        /*    var brands = new List<Brand>
            {
                new Brand{BrandID="1",BrandTitle="Pran"},
                new Brand{BrandID="2",BrandTitle="DeshiShad"},
                new Brand{BrandID="3",BrandTitle="BakenFake"},

            };
            brands.ForEach(s => context.Brands.Add(s));
            context.SaveChanges();*/
        }
    }
}