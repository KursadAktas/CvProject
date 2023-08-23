using CvProject.Context;
using CvProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.ViewComponents
{
    public class _Experience : ViewComponent
    {
        CvContext _db = new CvContext();

        public IViewComponentResult Invoke()
        {
           var values = _db.Experiences.ToList();
            return View(values);
        }

    }
}
