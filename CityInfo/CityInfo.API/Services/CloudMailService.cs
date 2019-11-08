﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Services
{
    public class CloudMailService : IMailService
    {
        private string _mailTo = "admin@neutronbong.com";
        private string _mailFrom = "noreply@neutronbong.com";

        public void Send(string subject, string message)
        {
            //output to debug window
            Debug.WriteLine($"Mail from: {_mailFrom} to {_mailTo} with CloudMailService");
            Debug.WriteLine($"Subject: {subject}");
            Debug.WriteLine($"Message: {message}");
        }
    }
}
