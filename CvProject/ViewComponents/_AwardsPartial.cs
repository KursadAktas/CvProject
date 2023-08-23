using CvProject.Context;
using CvProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.ViewComponents
{
    public class _AwardsPartial : ViewComponent
    {
        CvContext _db = new CvContext();

        public IViewComponentResult Invoke()
        {
            var values = _db.Certificates.ToList();
            return View(values);
        }
    }
}
