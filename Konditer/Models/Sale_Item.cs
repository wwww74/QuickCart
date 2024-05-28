using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Konditer.Models
{
    public class Sale_Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Count_Sale { get; set; }
        public string Price { get; set; }
        public string? New_Price { get; set; }
    }
}
