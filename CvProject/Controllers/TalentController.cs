using CvProject.Context;
using CvProject.Models;
using CvProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.Controllers
{
    public class TalentController : Controller
    {
       TalentRepository _repository = new TalentRepository();
        public IActionResult Index()
        {
            var talents = _repository.List();
            return View(talents);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Talent t)
        {
            _repository.TAdd(t);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Talent t = _repository.Find(x => x.Id == id);
            _repository.TDelete(t);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var talent = _repository.Find(x=>x.Id == id);
            return View(talent);
        }

        [HttpPost]
        public IActionResult Update(Talent talent)
        {
            var talentUpdate = _repository.Find(x => x.Id == talent.Id);
            talentUpdate.Talent1 = talent.Talent1;
            talentUpdate.Ratio = talent.Ratio;

            _repository.TUpdate(talent);
            return RedirectToAction("Index");
        }
    }
}
