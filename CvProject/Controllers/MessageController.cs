using CvProject.Context;
using CvProject.Models;
using CvProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.Controllers
{
    public class MessageController : Controller
    {
        CommunicationRepository _communicationRepository = new CommunicationRepository();
        CvContext _db = new CvContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]

        public IActionResult Add()
        {

            return View();
        }
        [HttpPost]

        public IActionResult Add(Communication formData)
        {
            formData.Date = DateTime.Parse(DateTime.Now.ToString());
            _db.Communications.Add(formData);
            _db.SaveChanges();
            return RedirectToAction("Index" , "Default");
        }

        public IActionResult Delete(int id )
        {
            var values = _communicationRepository.Find(x=> x.Id == id);
            _communicationRepository.TDelete(values);
            return RedirectToAction("Index" , "Communication");
        }
    }
}
