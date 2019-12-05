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

        public Thing Convert()
        {
            Thing tmp = new Thing();
            tmp.Name = Name;
            tmp.Price = Price;
            tmp.Description = Description;
            tmp.Color = Color;
            tmp.Size = Size;
            tmp.Image = Image;
            return tmp;
        }
        public Shirt ConvertToShirt()
        {
            Shirt tmp = new Shirt();
            tmp.Copy(Convert());
            return tmp;
        }
        public Jeans ConvertToJeans()
        {
            Jeans tmp = new Jeans();
            tmp.Copy(Convert());
            return tmp;
        }

    }
}
