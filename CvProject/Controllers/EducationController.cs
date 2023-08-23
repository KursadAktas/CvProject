using CvProject.Models;
using CvProject.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.Controllers
{

    public class EducationController : Controller
    {
        EducationRepository _educationRepository = new EducationRepository();

       
        public IActionResult Index()
        {
            var education = _educationRepository.List();
            return View(education);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Education education)
        {
            _educationRepository.TAdd(education);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var education = _educationRepository.Find(x=> x.Id == id);
            _educationRepository.TDelete(education);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update (int id) 
        {
          var education = _educationRepository.Find(x=>x.Id == id);
            return View(education);
        }

        [HttpPost]
        public IActionResult Update(Education education)
        {
            var educationUpdate = _educationRepository.Find(x => x.Id == education.Id);
            educationUpdate.Title = education.Title;
            educationUpdate.Subtitle1 = education.Subtitle1;
            educationUpdate.Subtitle2 = education.Subtitle2;
            educationUpdate.Date = education.Date;
            educationUpdate.AverageNote = education.AverageNote;
            _educationRepository.TUpdate(educationUpdate);
            return RedirectToAction("Index");
        }
    }
}
