using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineShoppingStore.Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Pleas Enter your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Pleas Enter  the first Street Name")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        [Required(ErrorMessage = "Pleas Enter City Name")]
        public string City { get; set; }
        [Required(ErrorMessage = "Pleas Enter State Name")]
        public string State { get; set; }
        public string Zip { get; set; }
        [Required(ErrorMessage = "Pleas Enter Country Name")]
        public string Country { get; set; }
        public bool GiftWrap { get; set; }
    }
}
