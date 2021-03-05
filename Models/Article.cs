using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Киберфорум.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string _Text { get; set; }
        public string ImageUrl { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public List<Comment> Comments { get; set; }
        public Article()
        {
            Comments = new List<Comment>();
        }
    }
}
