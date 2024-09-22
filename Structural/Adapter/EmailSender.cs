using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Structural.Adapter
{
    public class EmailSender : INotificationSneder
    {
        public void SendNotification(int userId, Notification notification)
        {
            Console.WriteLine($"Send push notification to: {userId}, Title: {notification.Title}, Body: {notification.Body}");
        }
    }
}
