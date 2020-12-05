using ArtGaleryEF.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGaleryEF.Models
{
    public class ArtistViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Status Fame { get; set; }
    }
}
