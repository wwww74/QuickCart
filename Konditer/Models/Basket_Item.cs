﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Konditer.Models
{
    public class Basket_Item
    {
        public int Id { get; set; }
        public int Id_Item { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public float Start_Price { get; set; }
        public float End_Price { get; set; }
        public int Count { get; set; }
    }
}
