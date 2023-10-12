using DOTNET_Core_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DOTNET_Core_Project.Controllers
{
    public class DateController : Controller
    {
        public readonly ApplicationDbContext dbcontext;
        public DateController(ApplicationDbContext dbcontext)
        {
            this.dbcontext= dbcontext;
        }
        public IActionResult Index()
        {
           var result= dbcontext.randevulars.Include("musteriler").Include("veterinerler").ToList();
            return View(result);
        }
        public IActionResult Create()
        {
            ViewData["MusteriNo"] = new SelectList(dbcontext.musterilers, "MusteriNo", "MusteriAdi");
            ViewData["VeterinerNo"] = new SelectList(dbcontext.veterinerlers, "VeterinerNo", "VeterinerAdi");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Randevular randevular)
        {
            dbcontext.randevulars.Add(randevular);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            ViewData["MusteriNo"] = new SelectList(dbcontext.musterilers, "MusteriNo", "MusteriAdi");
            ViewData["VeterinerNo"] = new SelectList(dbcontext.veterinerlers, "VeterinerNo", "VeterinerAdi");
            var result = dbcontext.randevulars.Find(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(Randevular randevular)
        {
            dbcontext.Update(randevular);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            ViewData["MusteriNo"] = new SelectList(dbcontext.musterilers, "MusteriNo", "MusteriAdi");
            ViewData["VeterinerNo"] = new SelectList(dbcontext.veterinerlers, "VeterinerNo", "VeterinerAdi");
            var result = dbcontext.randevulars.Find(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Delete(Randevular randevular)
        {
            dbcontext.Remove(randevular);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
