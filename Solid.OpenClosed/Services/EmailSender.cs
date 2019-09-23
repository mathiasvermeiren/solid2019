using Solid.OpenClosed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.OpenClosed.Services
{
    public class EmailSender
    {
        public void Send(String userId, String content)
        {
            String email = this.GetUserInfo(userId).MailAdres;
            //Send email to mailadres
        }

        private UserInfo GetUserInfo(String userId)
        {
            //get userInfo based on userId
            UserInfo userInfo = new UserInfo();
            return userInfo;
        }

    }
}
