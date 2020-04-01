using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieStoreProject.Models;

namespace MovieStoreProject.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        MusicStoreEntities storeDB = new MusicStoreEntities();
        public ActionResult Index()
        {
           var genres=storeDB.Genres.ToList();
            return View(genres);
        }
        public ActionResult Browse(string genre)
        {
            var genrename = storeDB.Genres.Single(g=>g.Name==genre);
            return View(genrename);
        }
        public ActionResult Details(int id)
        {
            var album = new Album { Title = "the albumid id is " + id };
            return View(album);
        }

    }
}
