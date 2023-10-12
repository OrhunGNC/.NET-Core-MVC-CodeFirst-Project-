using DOTNET_Core_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DOTNET_Core_Project.Controllers
{
    public class HospitalController : Controller
    {
        public readonly ApplicationDbContext dbcontext;
        public HospitalController(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        public IActionResult Index()
        {
            var result = dbcontext.hastanelers.ToList();
            return View(result);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Hastaneler hastane)
        {
            dbcontext.hastanelers.Add(hastane);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var result = dbcontext.hastanelers.Find(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(int id,Hastaneler hastane)
        {
            dbcontext.Update(hastane);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var result = dbcontext.hastanelers.Find(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Delete(Hastaneler hastane)
        {
            dbcontext.Remove(hastane);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
