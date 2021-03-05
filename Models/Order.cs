using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Киберфорум.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int _Count { get; set; }
        public int _Type { get; set; }

        public int StuffId { get; set; }
        public Stuff Stuff { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
