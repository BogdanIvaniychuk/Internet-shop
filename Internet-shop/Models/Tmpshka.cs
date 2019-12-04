using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Internet_shop.Models
{
    public enum Things
    {
        [Display(Name = "Майки")]
        Shirt,
        [Display(Name = "Джинси")]
        Jeans
    }
    public class Tmpshka : Thing
    {
        public Things num { get; set; }
        public Shirt ConvertToShirt()
        {
            Shirt tmp = new Shirt();
            tmp.Name = Name;
            tmp.Price = Price;
            tmp.Description = Description;
            tmp.Color = Color;
            tmp.Size = Size;
            tmp.Image = Image;

            return tmp;
        }
        public Jeans ConvertToJeans()
        {
            Jeans tmp = new Jeans();
            tmp.Name = Name;
            tmp.Price = Price;
            tmp.Description = Description;
            tmp.Color = Color;
            tmp.Size = Size;
            tmp.Image = Image;
            return tmp;
        }

    }
}
