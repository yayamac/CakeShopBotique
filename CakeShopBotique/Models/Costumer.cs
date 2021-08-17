using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShopBotique.Models
{
    public class Costumer
    {
       
        
        [Required]
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Enter First and last name")]
        [StringLength(maximumLength: 20)]
        [Display(Name = "First Name")]
        public string Name { get; set; }



        [Required(ErrorMessage = "Enter youre password")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[a-zA-Z\\d]{8,}$", ErrorMessage = "Enter stronger password")]
        [DataType(DataType.Password)]
        [StringLength(8)]

        public string Password { get; set; }



        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[a-zA-Z\\d]{8,}$", ErrorMessage = "Enter stronger password")]
        [Compare("Password", ErrorMessage = "you entered wrong Password ")]
        [StringLength(8)]

        public string PasswordConfirm { get; set; }





        [Required(ErrorMessage = "Enter your email adrress")]
        [StringLength(20)]
        [DataType(DataType.EmailAddress)]
        public string EmailAdress { get; set; }


 
        public int ShopBagId { get; set; }


        public List<Purchase> Purchases { get; set; } = null; //List of history orders

    }
}
