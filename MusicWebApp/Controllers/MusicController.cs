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
        public async Task<IActionResult> Details(int? id)
        {
            var getDetails = await _db.Music.FindAsync(id);
            return View(getDetails);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Music mus)
        {
            if (ModelState.IsValid)
            {
                _db.Add(mus);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(mus);
        }
    }
}
