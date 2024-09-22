using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Structural.Adapter
{
    public interface INotificationSneder
    {
        void SendNotification(int userId, Notification notification);
    }
}
