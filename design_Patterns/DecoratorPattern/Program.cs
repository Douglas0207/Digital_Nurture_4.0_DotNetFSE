using System;
namespace DecoratorPatternExample
{
    public interface INotifier
    {
        void Send(string message);
    }
    public class EmailNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"[Email] Sending: {message}");
        }
    }
    public abstract class NotifierDecorator : INotifier
    {
        protected INotifier notifier;

        public NotifierDecorator(INotifier notifier)
        {
            this.notifier = notifier;
        }
        public virtual void Send(string message)
        {
            notifier.Send(message);
        }
    }
    public class SMSNotifier : NotifierDecorator
    {
        public SMSNotifier(INotifier notifier) : base(notifier) { }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"[SMS] Sending: {message}");
        }
    }
    public class SlackNotifier : NotifierDecorator
    {
        public SlackNotifier(INotifier notifier) : base(notifier) { }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"[Slack] Sending: {message}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decorator Pattern Example");

            INotifier notifier = new EmailNotifier();
            notifier = new SMSNotifier(notifier);
            notifier = new SlackNotifier(notifier);

            notifier.Send("Server is Down!!!");
        }
    }
}