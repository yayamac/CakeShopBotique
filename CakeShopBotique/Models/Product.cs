
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CakeShopBotique.Models

{
    public class Product
    {
        public enum ProductType
        {
            BirthdayAdults,
            BirthdayKids,
            Wedding,
            Fur,
            Milk,
            GlutenFree
        }

        [Required]
        [Key]
        public int Id { get; set; }


        [Required]
        public string Category { get; set; }//Birthday, wedding, kids, adults...

        [Required]
        [Display(Name = "Cake Name")]
        public string ProductName { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        [Range(0, 9999)]

        public double Price { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public ProductType Type { get; set; }

       

        public List<Image> Images { get; set; }


    }

}
