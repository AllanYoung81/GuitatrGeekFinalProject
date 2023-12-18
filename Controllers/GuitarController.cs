using GuitatrGeekFinalProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GuitatrGeekFinalProject.Controllers
{
    public class GuitarController : Controller
    {
        private readonly IGuitarRepository repo;

        public GuitarController(IGuitarRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
           var guitars = repo.GetAllGuitars();
            return View(guitars);
        }
    }
}
