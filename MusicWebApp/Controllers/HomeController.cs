using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicWebApp.DAL;
using MusicWebApp.ViewModels;
using MusicWebApp.DAL;

namespace MusicWebApp.Controllers
{
    

    public class HomeController : Controller
    {
        private MusicContext db = new MusicContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            IQueryable<ArtistAlbums> data = from album in db.Album
                                                   group album by album.album_recording_company into albumGroup
                                                   select new ArtistAlbums()
                                                   {
                                                       album_recording_company = albumGroup.Key,
                                                       AlbumCount = albumGroup.Count()
                                                   };
            return View(data.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}