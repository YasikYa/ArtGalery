using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGaleryEF.Models
{
    public class ArtistOrdersViewModel
    {
        public Guid ArtistId { get; set; }

        public string Name { get; set; }

        public IEnumerable<ArtistOrderListModel> Orders { get; set; }
    }

    public class ArtistOrderListModel
    {
        public Guid PictureId { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public int Count { get; set; }
    }
}
