using ArtGaleryEF.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGaleryEF.Data.Entities
{
    public class Artist
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Status FameStatus { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
