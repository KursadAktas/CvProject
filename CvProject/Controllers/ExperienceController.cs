using CvProject.Models;
using CvProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceRepository experienceRepository = new ExperienceRepository();
        public IActionResult Index()
        {
            var values = experienceRepository.List();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            experienceRepository.TAdd(experience);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            Experience t = experienceRepository.Find(x=>x.Id == id);
            experienceRepository.TDelete(t);
            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult Update(int id)
        {
            Experience t = experienceRepository.Find(x => x.Id == id);
            return View(t);
        }

        [HttpPost]

        public IActionResult Update(Experience e)
        {
            Experience t = experienceRepository.Find(x => x.Id == e.Id);
            t.Title = e.Title;
            t.Description = e.Description;
            t.Date = e.Date;
            t.Subtitle = e.Subtitle;
            experienceRepository.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}
