using DOTNET_Core_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System.Linq;

namespace DOTNET_Core_Project.Controllers
{
    public class SpeciesController : Controller
    {
        public readonly ApplicationDbContext dbcontext;
        public SpeciesController(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        public IActionResult Index()
        {
            var result = dbcontext.turlers.ToList();
            return View(result);
        }
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Create(Turler turler)
        {
            dbcontext.turlers.Add(turler);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var result = dbcontext.turlers.Find(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(Turler turler)
        {
            dbcontext.Update(turler);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            var result = dbcontext.turlers.Find(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Delete(Turler turler)
        {
            dbcontext.Remove(turler);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
