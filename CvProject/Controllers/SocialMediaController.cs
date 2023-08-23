using CvProject.Entity;
using CvProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.Controllers
{
    public class SocialMediaController : Controller
    {
        SocialMediaRepository _repository = new SocialMediaRepository();
        public IActionResult Index()
        {
            var social = _repository.List();
            return View(social);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(SocialMedia socialMedia)
        {
            _repository.TAdd(socialMedia);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = _repository.Find(x=>x.Id == id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Update(SocialMedia p)
        {
            var value = _repository.Find(x => x.Id == p.Id);
            value.Name = p.Name;
            value.Link = p.Link;
            value.Icon = p.Icon;
            _repository.TUpdate(value);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var value = _repository.Find(x=> x.Id == id);
            _repository.TDelete(value);
            return RedirectToAction("Index");

            // var value = repo.Find(x=>x.Id == Id);
            // value.Durum = false; ders 62 // 
        }
    }
}
