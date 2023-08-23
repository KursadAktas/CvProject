using CvProject.Context;
using CvProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.ViewComponents
{
    public class _ComminicationPartial : ViewComponent
    {
        CvContext _db = new CvContext();

        public IViewComponentResult Invoke()
        {
            var values = _db.Communications.ToList();
            return View();

        }
    }
}
