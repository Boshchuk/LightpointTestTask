using System.Collections.Generic;
using System.Linq;
using LightpointTestTask.Models;

namespace LightpointTestTask.DAL
{
    public class LightpointInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LightpointContext>
    {
        protected override void Seed(LightpointContext context)
        {
            var proudcts = new List<Product>
            {
                new Product {ProductName = "Product 1", Description = "Prodcut 1 Description"},
                new Product {ProductName = "Product 3", Description = "Prodcut 3 Description"},
                new Product {ProductName = "Product 2", Description = "Prodcut 2 Description"},
                new Product {ProductName = "Product 4", Description = "Prodcut 4 Description"},
            };
            
            proudcts.ForEach(p=> context.Products.Add(p));
            context.SaveChanges();
            
            var stores = new List<Store>
            {
                new Store
                {
                    StoreName = "Store 1",
                    Address = "Address Line for Store 1",
                    Products = proudcts.Where(p => p.ProductId%2 == 0).ToList(),
                    WorkHours = "8:00 - 22:00"
                },
                new Store
                {
                    StoreName = "Store 2",
                    Address = "Address Line for Store 2",
                    Products = proudcts.Where(p => p.ProductId%2 != 0).ToList(),
                    WorkHours = "8:00 - 22:00"
                },
            };

            stores.ForEach(s=> context.Stores.Add(s));
            context.SaveChanges();
        }
    }
}