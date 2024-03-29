using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidAssignment
{
    public class NotificationService
    {
        private readonly Dictionary<NotificationType, INotificationSender> _notificationSender;

        public NotificationService()
        {
            _notificationSender = new Dictionary<NotificationType, INotificationSender>();
        }

        public void AddNotificationType(NotificationType notificationType, INotificationSender notificationSender)
        {
            _notificationSender.Add(notificationType, notificationSender);  
        }
        public void SendNotification(Notification notification, string destinatar, string message)
        {
            if (_notificationSender.ContainsKey(notification.Type))
            {
                INotificationSender notificationSender = _notificationSender[notification.Type];
                notificationSender.SendNotification(notification, destinatar, message);
;            }
            else
            {
                throw new InvalidOperationException("Invalid notification type");
            }
        }
    }
}
