using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Киберфорум.Models
{
    public class User
    {
        public int Id { get; set; }
        public string _Username { get; set; }
        public string _Password { get; set; }
        public string _Name { get; set; }
        public int? RoleId { get; set; }
        public Role Role { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Order> Orders { get; set; }
        public List<Article> Articles { get; set; }
        public List<Review> Reviews { get; set; }
        public User()
        {
            Comments = new List<Comment>();
            Orders = new List<Order>();
            Articles = new List<Article>();
            Reviews = new List<Review>();
        }
    }
}
