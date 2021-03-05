using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Киберфорум.Models
{
    public class Stuff
    {
        public int Id { get; set; }
        public int _Cost { get; set; }
        public string _Name { get; set; }
        public string ImageUrl { get; set; }
        public string Type { get; set; }
        public string Description { get;set;}
        public string Firm { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }

        public List<Review> Reviews { get; set; }
        public List<Order> Orders { get; set; }
        public Stuff()
        {
            Orders = new List<Order>();
            Reviews = new List<Review>();
        }
    }
}
