using ArtGaleryEF.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGaleryEF.Models
{
    public class PictureOrdersViewModel
    {
        public Guid PictureId { get; set; }

        public string Title { get; set; }

        public IEnumerable<PictureOrderListModel> Orders { get; set; }
    }

    public class PictureOrderListModel
    {
        public Guid ArtistId { get; set; }

        public string ArtistName { get; set; }

        public DateTime Date { get; set; }

        public Status ArtistFameStatus { get; set; }

        public int Count { get; set; }
    }
}
