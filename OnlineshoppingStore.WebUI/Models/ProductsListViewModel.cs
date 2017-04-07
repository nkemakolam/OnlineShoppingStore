using OnlineShoppingStore.Domain.Entities;
using System.Collections.Generic;
using System.Web.Mvc;
namespace OnlineshoppingStore.WebUI.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }

    }
}