using CvProject.Context;
using CvProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.ViewComponents
{
    public class _AboutPartial : ViewComponent
    {
        CvContext _db = new CvContext();

        public IViewComponentResult Invoke()
        {
            var values = _db.Abouts.ToList();
            return View(values);
        }
    }
}
