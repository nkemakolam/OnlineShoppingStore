using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineShoppingStore.Domain.Entities
{
    public class Product
    {
       
        public int ProductId { get; set; }
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public decimal Price { get; set; }
        //[Required(ErrorMessage ="Please define the Category of product")]
        public string Category { get; set; }
    }

}
