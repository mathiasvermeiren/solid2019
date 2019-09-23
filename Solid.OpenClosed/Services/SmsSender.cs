using Solid.OpenClosed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.OpenClosed.Services
{
    public class SmsSender
    {

        public void Send(String userId, String content)
        {
            string phoneNumber = this.GetUserInfo(userId).PhoneNumber;
            //Send text to phonenumber
        }

        private UserInfo GetUserInfo(String userId)
        {
            //get userInfo based on userId
            UserInfo userInfo = new UserInfo();
            return userInfo;
        }

    }
}
