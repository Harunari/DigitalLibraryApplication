using System;
using Xunit;
using System.Collections.Generic;
using System.Text;
using DigitalLibraryApplication.Services;

namespace DigitalLibraryUnitTests
{
    public class EmailServiceTests
    {
        [Fact]
        public void SendEmail_NoConditions_Success()
        {
            var service = new EmailService();
            service.SendEmail();

            Assert.True(service.MailSent);
        }
    }
}
