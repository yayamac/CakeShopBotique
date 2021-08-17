using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShopBotique.Models
{
    public class Purchase
    {
        [Required]
        [Key]
        public int Id { get; set; }

        //[Required]
        //public int AddressId { get; set; }

        [Required]
        public DateTime Date { get; set; } = DateTime.Now;

        [Required]
        public int CostumerId { get; set; }


        public double TotalPrice { get; set; }

        [Required]
        [DataType(DataType.CreditCard)]
        public string PaymentMethod { get; set; } 

        public List<ShopBagProduct> PurchaseProducts { get; set; }

    }
}
