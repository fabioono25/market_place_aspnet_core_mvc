using System.Collections.Generic;

namespace MarketPlace.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
