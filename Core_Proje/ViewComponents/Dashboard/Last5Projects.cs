using Business_Layer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class Last5Projects : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
    
}
