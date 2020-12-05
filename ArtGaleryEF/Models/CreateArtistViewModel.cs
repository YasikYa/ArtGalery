using ArtGaleryEF.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGaleryEF.Models
{
    public class CreateArtistViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Status FameStatus { get; set; }
    }
}
