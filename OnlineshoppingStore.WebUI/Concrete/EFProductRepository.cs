using OnlineShoppingStore.Domain.Abstract;
using OnlineShoppingStore.Domain.Entities;
using System.Collections.Generic;

namespace OnlineshoppingStore.WebUI.Concrete
{
    public class EFProductRepository : IProductRepository
    {

        private readonly EFDbContext context = new EFDbContext();
        public IEnumerable<Product> Products
        {
            get
            {
                return context.Products;
            }
        }

        public void SaveProduct(Product product)
        {
            if (product.ProductId == 0)
            {
                context.Products.Add(product);
            }
            else
            {
                Product dbEntry = context.Products.Find(product.ProductId);
                if (dbEntry != null)
                {
                    dbEntry.Name = product.Name;
                    dbEntry.Description = product.Description;
                    dbEntry.Price = product.Price;
                    dbEntry.Category = product.Category;
                }
            }
            context.SaveChanges();
        }
    }
}