using CvProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.Controllers
{
    public class CommunicationController : Controller
    {
        CommunicationRepository _communicationRepository = new CommunicationRepository();
        public IActionResult Index()
        {
          var communication =  _communicationRepository.List();
            return View(communication);
        }
    }
}
