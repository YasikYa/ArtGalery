using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGaleryEF.Models
{
    public class PictureViewModel
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public int Age { get; set; }
    }
}
