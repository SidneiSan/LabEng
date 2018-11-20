using Myfactory.SIT.app.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Myfactory.SIT.app.Controllers
{
    public class BaseController : Controller
    {

        protected override void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;

            var exception = filterContext.Exception;
            if (exception != null)
            {
                this.AddNotification(exception.Message, NotificationType.ERROR);
            }

        }

    }
}