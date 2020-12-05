using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ArtGaleryEF.Data;
using ArtGaleryEF.Data.Entities;
using ArtGaleryEF.Data.Enums;
using ArtGaleryEF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace ArtGaleryEF.Controllers
{
    public class HomeController : Controller
    {
        private ArtContext _context;

        public HomeController(ArtContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var pictures = _context.Pictures.Select(p => new PictureViewModel
            {
                Id = p.Id,
                Age = p.Age,
                Title = p.Title
            }).ToList();
            return View(pictures);
        }

        public IActionResult Orders(Guid id)
        {
            var orders = _context.Pictures.Where(p => p.Id == id).Select(p => new PictureOrdersViewModel
            {
                PictureId = p.Id,
                Title = p.Title,
                Orders = p.Orders.Select(o => new PictureOrderListModel
                {
                    ArtistId = o.Artist.Id,
                    ArtistName = $"{o.Artist.FirstName} {o.Artist.LastName}",
                    Date = o.Date,
                    ArtistFameStatus = o.Artist.FameStatus,
                    Count = o.Count
                })
            }).FirstOrDefault();

            return View(orders);
        }

        public IActionResult AddOrder(Guid id, string callbackUrl, Status? fameFilter = null)
        {
            ViewBag.PictureId = id;
            ViewBag.PictureTitle = _context.Pictures.Where(p => p.Id == id).Select(p => p.Title).FirstOrDefault();
            ViewBag.CallbackUrl = callbackUrl;
            PopulateArtistsDropdown(fameFilter);
            PopulateArtistFilterDropdow();
            return View();
        }

        [HttpPost]
        public IActionResult AddOrderFilter(Guid id, string callbackUrl, Status? fameFilter)
        {
            return RedirectToAction("AddOrder", new { id, callbackUrl, fameFilter });
        }

        [HttpPost]
        public IActionResult AddOrder(CreateOrderViewModel createModel, string callbackUrl)
        {
            var artist = _context.Artists.Where(a => a.Id == createModel.ArtistId).FirstOrDefault();
            var picture = _context.Pictures.Where(p => p.Id == createModel.PictureId).FirstOrDefault();
            _context.Orders.Add(new Order { Artist = artist, Picture = picture, Id = Guid.NewGuid(), Date = DateTime.Now, Count = createModel.Count });
            _context.SaveChanges();
            return Redirect(callbackUrl);
        }

        public IActionResult CreatePicture()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePicture(CreatePictureModel createModel)
        {
            _context.Pictures.Add(new Picture
            {
                Id = Guid.NewGuid(),
                Age = createModel.Age,
                Title = createModel.Title
            });
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        private void PopulateArtistsDropdown(Status? fameFilter = null)
        {
            var selectedArtists = fameFilter.HasValue ? _context.Artists.Where(a => a.FameStatus.Equals(fameFilter.Value)) : _context.Artists;
            ViewBag.Artist = selectedArtists.Select(a => new SelectListItem { Text = $"{a.FirstName} {a.LastName}", Value = a.Id.ToString() });
        }

        private void PopulateArtistFilterDropdow()
        {
            var selectList = new List<SelectListItem>();
            selectList.Add(new SelectListItem { Text = Status.Famous.ToString(), Value = Status.Famous.ToString() });
            selectList.Add(new SelectListItem { Text = Status.Unfamous.ToString(), Value = Status.Unfamous.ToString() });
            selectList.Add(new SelectListItem { Text = "All", Value = null });
            ViewBag.StatusFilter = selectList;
        }
    }
}
