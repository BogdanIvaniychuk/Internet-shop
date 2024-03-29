﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Internet_shop.Models
{

    public class Thing
    {
        //private static int count = 0;
        private int id;
        private string name;
        private int price;
        private string description;
        private string color;
        private string size;
        private string image;
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Price { get { return price; } set { price = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string Color { get { return color; } set { color = value; } }
        public string Size { get { return size; } set { size = value; } }
        public string Image { get { return image; } set { image = value; } }


        public void Copy(Thing tmp)
        {
            Name = tmp.Name;
            Price = tmp.Price;
            Description = tmp.Description;
            Color = tmp.Color;
            Size = tmp.Size;
            Image = tmp.Image;
        }
    }
}
