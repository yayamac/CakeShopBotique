using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShopBotique.Models
{
    public class ShopBagProduct
    {
        public int Id { get; set; }

        [Required]
        public int Quantity { get; set; } = 1;

        [Required]
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        [MaxLength(10)]
        public string CustumName { get; set; } = null;

        public int ShopBagId { get; set; } //ShopBagId = CartId
    }
}
