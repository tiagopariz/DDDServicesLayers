using System;

namespace DDDServicesLayers.Infra.Messages.MessagesServices
{
    public class EmailService
    {
        public EmailService(string to,
                            string subject,
                            string body)
        {
            To = to;
            Subject = subject;
            Body = body;
        }

        public string To { get; private set; }
        public string Subject { get; private set; }
        public string Body { get; private set; }
        public bool Success { get; private set; }

        public void Send()
        {
            // Send e-mail
            Success = true;
        }
    }
}