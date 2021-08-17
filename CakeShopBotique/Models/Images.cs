using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShopBotique.Models
{
    public class Image
    {
        public enum ImageType
        {
            BirtdhayAdults,
            BirthdayKids,
            Wedding,
            Girls,
            Boys,
            Profile,
            Category
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public byte[] Images { get; set; }

        public int? ProductId { get; set; }

        public ImageType Type { get; set; }

    }
}
