using DOTNET_Core_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Reflection.Metadata;

namespace DOTNET_Core_Project.Controllers
{
    public class CustomerController : Controller
    {
        public readonly ApplicationDbContext dbcontext;
        public CustomerController(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        public IActionResult Index()
        {
            var result = dbcontext.musterilers.Include("pets").ToList();
            return View(result);
        }
        public IActionResult Create()
        {
            ViewData["PetNo"] = new SelectList(dbcontext.petss, "PetNo", "PetAdi");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Musteriler musteriler)
        {
            dbcontext.musterilers.Add(musteriler);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Edit(int id)
        {
            ViewData["PetNo"] = new SelectList(dbcontext.petss, "PetNo", "PetAdi");
            var result = dbcontext.musterilers.Find(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(Musteriler musteriler)
        {
            dbcontext.Update(musteriler);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            ViewData["PetNo"] = new SelectList(dbcontext.petss, "PetNo", "PetAdi");
            var result = dbcontext.musterilers.Find(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Delete(Musteriler musteriler)
        {
            dbcontext.Remove(musteriler);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
