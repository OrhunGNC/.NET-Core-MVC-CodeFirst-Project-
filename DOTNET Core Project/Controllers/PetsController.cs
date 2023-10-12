using DOTNET_Core_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DOTNET_Core_Project.Controllers
{
    public class PetsController : Controller
    {
        public readonly ApplicationDbContext dbcontext;
        public PetsController(ApplicationDbContext dbcontext)
        {
            this.dbcontext= dbcontext;
        }
        public IActionResult Index()
        {
            
            var result = dbcontext.petss.Include("turler").ToList();
            return View(result);
        }
        public IActionResult Create()
        {
            ViewData["TurNo"] = new SelectList(dbcontext.turlers, "TurNo", "TurAdi");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Pets pets)
        {
            dbcontext.petss.Add(pets);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            ViewData["TurNo"] = new SelectList(dbcontext.turlers, "TurNo", "TurAdi");
            var result = dbcontext.petss.Find(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(Pets pets)
        {
            dbcontext.Update(pets);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var result = dbcontext.petss.Find(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Delete(Pets pets)
        {
            dbcontext.Remove(pets);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
