using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Киберфорум.Models
{
    public class StoreViewModel
    {
        public IEnumerable<Stuff> Stuffs { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public StuffFilterViewModel StuffFilterViewModel { get; set; }
    }
}
