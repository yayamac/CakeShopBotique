using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace CakeShopBotique.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }////Birthday, wedding, kids, adults...

        public List<Product> Products { get; set; }

        public Image Image { get; set; }

    }
}
