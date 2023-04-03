using Business_Layer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
        UserMessageManager messageManager = new UserMessageManager(new EfUserMessageDal());
        public IViewComponentResult Invoke()
        {
            var values = messageManager.TGetUserMessagesWithUser();
            return View(values);
        }
    }

}

