

SMSNotificationAdapter smsNotification = new();
smsNotification.Notify("Hello, World!");

interface INotification
{
    void Notify(string message);
}

class Notification : INotification
{
    public void Notify(string message)
    {
        Console.WriteLine($"Notification: {message}");
    }
}

class SMSNotification
{
    public void SendSMS(string message)
    {
        Console.WriteLine($"SMS Notification: {message}");
    }
}

class SMSNotificationAdapter : INotification
{
    private readonly SMSNotification _smsNotification;

    public SMSNotificationAdapter(SMSNotification smsNotification)
    {
        _smsNotification = smsNotification;
    }


    public void Notify(string message)
    {
        _smsNotification.SendSMS(message);
    }
}
