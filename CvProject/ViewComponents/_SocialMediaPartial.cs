using CvProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.ViewComponents
{
    public class _SocialMediaPartial : ViewComponent
    {
        CvContext _db = new CvContext();
        public IViewComponentResult Invoke()
        {
                var values = _db.SocialMedias.ToList();
                return View(values);
            
        }
    }
}
