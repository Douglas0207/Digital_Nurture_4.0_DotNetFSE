namespace EmailService
{
    public interface IEmailSender
    {
        bool SendEmail(string to, string subject, string body);
    }

    public class NotificationService
    {
        private readonly IEmailSender _emailSender;

        public NotificationService(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public string SendNotification(string userEmail)
        {
            bool result = _emailSender.SendEmail(userEmail, "Welcome!", "Thanks for signing up!");

            if (result)
                return "Email sent";
            else
                return "Failed to send email";
        }
    }
}
