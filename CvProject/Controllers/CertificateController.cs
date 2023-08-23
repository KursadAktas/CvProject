using CvProject.Models;
using CvProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.Controllers
{
    public class CertificateController : Controller
    {
        CertificatesRepository _certificatesRepository = new CertificatesRepository();
        public IActionResult Index()
        {
           var certificate = _certificatesRepository.List();
            return View(certificate);
        }
        [HttpGet]
        public IActionResult Add(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Certificate certificate)
        {
            _certificatesRepository.TAdd(certificate);
           
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Certificate certificae = _certificatesRepository.Find(x=> x.Id == id);
            _certificatesRepository.TDelete(certificae);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Certificate update = _certificatesRepository.Find(x=>x.Id == id);
            return View(update);
        }

        [HttpPost]
        public IActionResult Update(Certificate certificate)
        {
            Certificate update = _certificatesRepository.Find(x=>x.Id==certificate.Id);
            update.Description = certificate.Description;
            update.Date = certificate.Date;
            _certificatesRepository.TUpdate(update);
            return RedirectToAction("Index");
        }
    }
}
