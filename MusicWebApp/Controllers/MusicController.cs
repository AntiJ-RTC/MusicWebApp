using Microsoft.AspNetCore.Mvc;
using MusicWebApp.Models;

namespace MusicWebApp.Controllers
{
    public class MusicController : Controller
    {
        private readonly MWAContext _db;
        public MusicController(MWAContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var data = _db.Music.ToList();
            return View(data);
        }
    }
}
