using MailboxIntegration.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MailboxIntegration.Controllers
{
    public class MailController : BaseController
    {
        // GET: Mail
        public async Task<ActionResult> Index()
        {
            var mailList = await GraphHelper.GetEventsAsync();
            foreach (var ev in mailList)
            {
                ev.BodyPreview = ev.BodyPreview.ToString();
                ev.Body = ev.Body;
                ev.Subject = ev.Subject.ToString();
            }

            return View(mailList);
        }
    }
}