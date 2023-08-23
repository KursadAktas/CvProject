using CvProject.Context;
using CvProject.Models;
using CvProject.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.Controllers
{
  
    public class AboutController : Controller
    {
        AboutRepository _aboutRepository = new AboutRepository();

        public IActionResult Index()
        {
            var about = _aboutRepository.List();
            return View(about);
        }
        [HttpGet]
        public IActionResult Add(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(About about)
        {
            _aboutRepository.TAdd(about);

            return RedirectToAction("Index");
        }

    

        [HttpGet]
        public IActionResult Update(int id)
        {
            About update = _aboutRepository.Find(x => x.Id == id);
            return View(update);
        }

        [HttpPost]
        public IActionResult Update(About about)
        {
            About update = _aboutRepository.Find(x => x.Id == about.Id);
            update.Name = about.Name;
            update.LastName = about.LastName;
            update.Adress = about.Adress;
            update.Phone = about.Phone;
            update.Mail = about.Mail;
            update.Description = about.Description;
            update.Image = about.Image;
            
            _aboutRepository.TUpdate(update);
            return RedirectToAction("Index");
        }
    }


}

