using NUnit.Framework;
using Moq;
using EmailService;

namespace EmailService.Tests
{
    public class NotificationServiceTests
    {
        [Test]
        public void SendNotification_EmailSent_ReturnsSuccessMessage()
        {
            var mockEmailSender = new Mock<IEmailSender>();
            mockEmailSender.Setup(m => m.SendEmail(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(true);

            var service = new NotificationService(mockEmailSender.Object);
            var result = service.SendNotification("user@example.com");

            Assert.AreEqual("Email sent", result);
        }

        [Test]
        public void SendNotification_EmailFails_ReturnsFailureMessage()
        {
            var mockEmailSender = new Mock<IEmailSender>();
            mockEmailSender.Setup(m => m.SendEmail(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(false);

            var service = new NotificationService(mockEmailSender.Object);
            var result = service.SendNotification("user@example.com");

            Assert.AreEqual("Failed to send email", result);
        }
    }
}
