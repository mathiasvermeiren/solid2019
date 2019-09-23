using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.OpenClosed.Services
{
    public class NotificationService
    {
        public bool SendBySms(String userId, String templateId)
        {
            SmsSender sender = new SmsSender();
            String content = this.GetContent(templateId);
            sender.Send(userId, content);

            return true;
        }

        public bool SendByEmail(String userId, String templateId)
        {
            EmailSender sender = new EmailSender();
            String content = this.GetContent(templateId);
            sender.Send(userId, content);

            return true;
        }

        private String GetContent(String templateId)
        {
            //get template on templateId
            String content = "";

            return content;
        }

    }
}
