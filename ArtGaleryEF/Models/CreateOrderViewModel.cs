using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGaleryEF.Models
{
    public class CreateOrderViewModel
    {
        public Guid PictureId { get; set; }

        public Guid ArtistId { get; set; }

        public int Count { get; set; }
    }
}
