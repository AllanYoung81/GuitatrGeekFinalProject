using GuitatrGeekFinalProject.Models;
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

        public IActionResult ViewGuitar(int id)
        {
            var guitar = repo.GetGuitar(id);
            return View(guitar);
        }

        public IActionResult UpdateGuitar(int id)
        {
            Guitar guitars = repo.GetGuitar(id);
            if (guitars == null)
            {
                return View("GuitarNotFound");
            }
            return View(guitars);
        }
        public IActionResult UpdateGuitarToDatabase(Guitar guitar)
        {
            repo.UpdateGuitar(guitar);

            return RedirectToAction("ViewGuitar", new { id = guitar.GuitarID });
        }

        public IActionResult InsertGuitar()
        {
            var guitar = repo.AssignGuitarCategory();

            return View(guitar);    
        }

        public IActionResult InsertGuitarToDatabase(Guitar guitarToInsert) 
        { 
            repo.InsertGuitar(guitarToInsert);

            return RedirectToAction("Index");
        }
        public IActionResult DeleteGuitar(Guitar guitar)
        {
            repo.DeleteGuitar(guitar);

            return RedirectToAction("Index");
        }
    }
}
