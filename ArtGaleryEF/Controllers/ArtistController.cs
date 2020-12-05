using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtGaleryEF.Data;
using ArtGaleryEF.Data.Entities;
using ArtGaleryEF.Data.Enums;
using ArtGaleryEF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ArtGaleryEF.Controllers
{
    public class ArtistController : Controller
    {
        private ArtContext _context;

        public ArtistController(ArtContext context) => _context = context;

        public IActionResult Index()
        {
            var artists = _context.Artists.Select(a => new ArtistViewModel
            {
                Id = a.Id,
                Name = $"{a.FirstName} {a.LastName}",
                Fame = a.FameStatus
            }).ToList();
            return View(artists);
        }

        public IActionResult CreateArtist()
        {
            PopulateFameStatusDropDown();
            return View(new CreateArtistViewModel());
        }

        [HttpPost]
        public IActionResult CreateArtist(CreateArtistViewModel createModel)
        {
            _context.Artists.Add(new Artist
            {
                Id = Guid.NewGuid(),
                FirstName = createModel.FirstName,
                LastName = createModel.LastName,
                FameStatus = createModel.FameStatus
            });
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(Guid id)
        {
            var artistDetails = _context.Artists.Where(a => a.Id == id).Select(a => new ArtistOrdersViewModel
            {
                ArtistId = a.Id,
                Name = $"{a.FirstName} {a.LastName}",
                Orders = a.Orders.Select(o => new ArtistOrderListModel
                {
                    PictureId = o.Picture.Id,
                    Title = o.Picture.Title,
                    Count = o.Count,
                    Date = o.Date
                })
            }).FirstOrDefault();
            return View(artistDetails);
        }

        private void PopulateFameStatusDropDown()
        {
            var selectList = new List<SelectListItem>();
            selectList.Add(new SelectListItem { Text = Status.Famous.ToString(), Value = Status.Famous.ToString() });
            selectList.Add(new SelectListItem { Text = Status.Unfamous.ToString(), Value = Status.Unfamous.ToString() });
            ViewBag.StatusFilter = selectList;
        }
    }
}
