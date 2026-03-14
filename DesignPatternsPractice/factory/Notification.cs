
interface INotification
{
    void Notify(string message);
}


class EmailNotification : INotification
{
    public void Notify(string message)
    {
        Console.WriteLine($"Email Notification: {message}");
    }
}

class SMSNotification : INotification
{
    public void Notify(string message)
    {
        Console.WriteLine($"SMS Notification: {message}");
    }
}

class PushNotification : INotification
{
    public void Notify(string message)
    {
        Console.WriteLine($"Push Notification: {message}");
    }
}

interface INotificationFactory
{
    INotification CreateNotification(string type);
}


class NotificationFactory : INotificationFactory
{
    private static readonly Dictionary<string, Func<INotification>> creators = new Dictionary<string, Func<INotification>>();

    public static void RegisterNotification(string type, Func<INotification> creator)
    {
        creators[type] = creator;
    }

    public  INotification CreateNotification(string type)
    {
        if (creators.ContainsKey(type))
        {
            return creators[type]();
        }
        throw new ArgumentException($"Notification type '{type}' is not registered.");
    }
}


class NotificationService
{
    private readonly INotificationFactory _factory;

    public NotificationService(INotificationFactory factory)
    {
        _factory = factory;
    }

    public void SendNotification(string type, string message)
    {
        INotification notification = _factory.CreateNotification(type);
        notification.Notify(message);
    }
}


