using System.Collections.Generic;

namespace Киберфорум.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Comment> Comments { get; set; }
        public IEnumerable<Article> Articles { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
