using System;

namespace Konditer.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Image { get; set; }
        public float Ccal { get; set; }
        public float Belok { get; set; }
        public float Jir { get; set; }
        public float Uglevod { get; set; }
        public string Sostav { get; set; }
        public string Srok { get; set; }
        public string Proizod { get; set; }
    }
}