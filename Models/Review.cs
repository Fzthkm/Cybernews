using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Киберфорум.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string _Text { get; set; }
        public int Rate { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public int? StuffId { get; set; }
        public Stuff Stuff { get; set; }
    }
}
