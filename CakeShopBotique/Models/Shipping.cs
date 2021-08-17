using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShopBotique.Models
{
    public class Shipping
    {
        public int Id { get; set; }


        [Required]
        [DataType(DataType.PhoneNumber)]
        public long PhoneNumber { get; set; }


        [Required]
        public string Country { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string HouseNumber { get; set; }

        public int Floor { get; set; }

        public int Apartment { get; set; }

        [Required]
        public int ZipCode { get; set; }
    }
}
