using CvProject.Context;
using CvProject.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.Controllers
{
    public class DefaultController : Controller
	{
		CvContext _db = new CvContext();
        [AllowAnonymous]
        public IActionResult Index()
		{
			var  values = _db.Abouts.ToList();
			return View(values);
		}
      
    }
}
