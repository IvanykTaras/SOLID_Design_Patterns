using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Structural.Adapter
{
    public class SmsSenderAdapter : INotificationSneder
    {
        private SmsSender _sender = new SmsSender();

        public void SendNotification(int userId, Notification notification)
        {
            string userPhone = null;//based userId
            _sender.SendSms(userPhone, $"{notification.Title}, {notification.Body}");
        }
    }
}
