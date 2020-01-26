using System;
using System.Collections.Generic;

namespace MarketPlace.Models
{
    public class PieRepository : IPieRepository
    {
        public IEnumerable<Pie> Pies => throw new NotImplementedException();

        public IEnumerable<Pie> PiesOfTheWeek => throw new NotImplementedException();

        public void CreatePie(Pie pie)
        {
            throw new NotImplementedException();
        }

        public Pie GetPieById(int pieId)
        {
            throw new NotImplementedException();
        }

        public void UpdatePie(Pie pie)
        {
            throw new NotImplementedException();
        }
    }
}
