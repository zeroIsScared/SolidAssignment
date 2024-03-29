using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidAssignment
{
    public interface INotificationSender
    {
        void SendNotification(Notification notification, string destinatar, string message);
    }
}
