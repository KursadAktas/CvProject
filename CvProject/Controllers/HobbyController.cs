using CvProject.Models;
using CvProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.Controllers
{
    public class HobbyController : Controller
    {
        HobbyRepository _hobbyRepository = new HobbyRepository();

        
        public IActionResult Index()
        {
            var hobby = _hobbyRepository.List();
            return View(hobby);
        }

        [HttpGet]
        public IActionResult Add(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Hobby hobby)
        {
            _hobbyRepository.TAdd(hobby);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Hobby hobby = _hobbyRepository.Find(x => x.Id == id);
            _hobbyRepository.TDelete(hobby);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Hobby update = _hobbyRepository.Find(x => x.Id == id);
            return View(update);
        }

        [HttpPost]
        public IActionResult Update(Hobby hobby)
        {
            Hobby update = _hobbyRepository.Find(x => x.Id == hobby.Id);
            update.Description1 = hobby.Description1;
            update.Description2 = hobby.Description2;
            _hobbyRepository.TUpdate(update);
            return RedirectToAction("Index");
        }
    }


}

