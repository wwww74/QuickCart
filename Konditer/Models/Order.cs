using System;
using System.Collections.Generic;
using System.Text;

namespace Konditer.Models
{
    public class Order
    {
        public int Id { get; set; }
        public float Summ { get; set; }
        public string Date { get; set; }
        public string Id_items { get; set; }
        public string Count_items { get; set; }
    }
}
