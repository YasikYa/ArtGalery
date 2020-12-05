using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGaleryEF.Data.Entities
{
    public class Order
    {
        public Guid Id { get; set; }

        public int Count { get; set; }

        public DateTime Date { get; set; }

        public Picture Picture { get; set; }

        public Artist Artist { get; set; }
    }
}
