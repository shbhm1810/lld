

interface INotifications
{
    void Notify(string message);
}

class Notification : INotifications
{
    public void Notify(string message)
    {
        Console.WriteLine($"Notification: {message}");
    }
}

class SMSNotifications
{
    public void SendSMS(string message)
    {
        Console.WriteLine($"SMS Notification: {message}");
    }
}

class SMSNotificationAdapter : INotification
{
    private readonly SMSNotifications _smsNotification;

    public SMSNotificationAdapter(SMSNotifications smsNotification)
    {
        _smsNotification = smsNotification;
    }


    public void Notify(string message)
    {
        _smsNotification.SendSMS(message);
    }
}
