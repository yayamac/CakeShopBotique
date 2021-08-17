using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShopBotique.Models
{
    public class ShopBag
    {
        public int Id { get; set; }

        public List<ShopBagProduct> ProductBagtId { get; set; }

        //not rquiered because if the user doesnt registered
        //he also can have a cart but it won't be writing in data base.
        //it will be temporary Cart.
        public int CostumerId { get; set; } //   CostumerId = UserId

        public double TotalPrice { get; set; } = 0; 

        public DateTime LastUpdate { get; set; }//after week we will clean the cart
    }
}
