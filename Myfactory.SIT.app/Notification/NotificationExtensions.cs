using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Myfactory.SIT.app.Controllers;

namespace Myfactory.SIT.app.Notification
{
    public static class NotificationExtensions
    {
        private static IDictionary<String, String> NotificationKey = new Dictionary<String, String>
        {
            { "Erro", "Myfactory.SIT.app.Notification.Error" },
            { "Alerta", "Myfactory.SIT.app.Notification.Warning" },
            { "Successo", "Myfactory.SIT.app.Notification.Success" },
            { "Informação", "Myfactory.SIT.app.Notification.Info" }
        };


        public static void AddNotification(this BaseController controller, String message, String notificationType)
        {
            string NotificationKey = getNotificationKeyByType(notificationType);
            ICollection<String> messages = controller.TempData[NotificationKey] as ICollection<String>;

            if (messages == null)
            {
                controller.TempData[NotificationKey] = (messages = new HashSet<String>());
            }

            messages.Add(message);
        }

        public static IEnumerable<String> GetNotifications(this HtmlHelper htmlHelper, String notificationType)
        {
            string NotificationKey = getNotificationKeyByType(notificationType);
            return htmlHelper.ViewContext.Controller.TempData[NotificationKey] as ICollection<String> ?? null;
        }

        private static string getNotificationKeyByType(string notificationType)
        {
            try
            {
                return NotificationKey[notificationType];
            }
            catch (IndexOutOfRangeException e)
            {
                ArgumentException exception = new ArgumentException("Key is invalid", "notificationType", e);
                throw exception;
            }
        }
    }

    public static class NotificationType
    {
        public const string ERROR = "Erro";
        public const string WARNING = "Alerta";
        public const string SUCCESS = "Successo";
        public const string INFO = "Informação";

    }
}