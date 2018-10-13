using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalLibraryApplication.Services
{
    public class EmailService
    {
        public bool MailSent { get; set; }

        public void SendEmail()
        {
            // Logic.
            MailSent = true;
        }
    }
}
