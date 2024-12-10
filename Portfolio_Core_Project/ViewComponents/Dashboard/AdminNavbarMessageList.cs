using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Portfolio_Core_Project.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList : ViewComponent
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IViewComponentResult Invoke()
        {
            //Context c = new Context();
            //foreach(var item in values)
            //{
            //    var img = c.Users.Where(x => x.Email == item.Sender).Select(x => x.ImageUrl).FirstOrDefault();
            //    item.ImageUrl = img;
            //}
            string p = "ozlmkrkoc@gmail.com";
            var values = writerMessageManager.GetListReceiverMessage(p).OrderByDescending(x => x.WriterMessageID).Take(3).ToList();
            return View(values);
        }

    }
}
