using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidAssignment
{
    public class EmailNotificationSender : INotificationSender
    {
        public void SendNotification (Notification notification, string destinatar, string message)
        {
            Console.WriteLine($"A {notification.Type} was send to - {destinatar} with text: {message}");
        }
    }
}
