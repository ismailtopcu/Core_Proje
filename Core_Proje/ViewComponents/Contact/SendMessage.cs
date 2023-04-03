using Business_Layer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Core_Proje.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
        SendMessageManager messageManager = new SendMessageManager(new EfMessageDal());
        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(Message p)
        //{
        //    p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    p.Status = true;
        //    messageManager.TAdd(p);
        //    return View();
        //}
    }
}
