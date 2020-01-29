using MarketPlace.Models;
using System.Collections.Generic;

namespace MarketPlace.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}
