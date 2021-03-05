using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Киберфорум.Models
{
    public class StuffFilterViewModel
    {
        public StuffFilterViewModel(List<Stuff> stuffs, int? stuff, string name)
        {
            stuffs.Insert(0, new Stuff { _Name = "Все", Id = 0 });
        }
        public SelectList Stuffs { get; private set; } // список товара
        public int? SelectedStuff { get; private set; }   // выбранный товар
        public string SelectedName { get; private set; }    // введенное название
    }
}
