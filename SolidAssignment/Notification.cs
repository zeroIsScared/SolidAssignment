using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidAssignment
{
public class Notification
    {
        public Notification (NotificationType type)
        {
            Type = type;
        }

        public NotificationType Type { get; set; }
    }
}
