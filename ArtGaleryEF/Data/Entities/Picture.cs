using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGaleryEF.Data.Entities
{
    public class Picture
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public int Age { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
