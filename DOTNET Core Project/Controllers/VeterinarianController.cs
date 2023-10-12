using DOTNET_Core_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DOTNET_Core_Project.Controllers
{
    public class VeterinarianController : Controller
    {
        public readonly ApplicationDbContext dbcontext;
        public VeterinarianController(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        public IActionResult Index()
        {
            var result = dbcontext.veterinerlers.Include("hastaneler").ToList();
            return View(result);
        }
        public IActionResult Create()
        {
            ViewData["HastaneNo"] = new SelectList(dbcontext.hastanelers, "HastaneNo", "HastaneAdres");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Veterinerler veteriner)
        {
            dbcontext.veterinerlers.Add(veteriner);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            ViewData["HastaneNo"] = new SelectList(dbcontext.hastanelers, "HastaneNo", "HastaneAdres");
            var result = dbcontext.veterinerlers.Find(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(Veterinerler veteriner)
        {
            dbcontext.Update(veteriner);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var result = dbcontext.veterinerlers.Find(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Delete(Veterinerler veteriner)
        {
            dbcontext.Remove(veteriner);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
