

interface ISubscriber
{
    void ReceiveNotification(string videoTitle);
}
class YoutubeChaneel
{
    private List<ISubscriber> subscribers = new List<ISubscriber>();

    public void UploadVieo(string videoTitle)
    {
        Console.WriteLine($"Video '{videoTitle}' uploaded to YouTube channel.");
        NotifySubscribers(videoTitle);
    }

    public void Subscribe(ISubscriber subscriber)
    {
        subscribers.Add(subscriber);
    }

    public void Unsubscribe(ISubscriber subscriber)
    {
        subscribers.Remove(subscriber);
    }

    private void NotifySubscribers(string videoTitle)
    {
        foreach (var subscriber in subscribers)
        {
            subscriber.ReceiveNotification(videoTitle);
        }
    }
}

class EmailSubscriber : ISubscriber
{
    public void ReceiveNotification(string videoTitle)
    {
        Console.WriteLine($"Email Subscriber: New video '{videoTitle}' uploaded.");
    }
}

class SMSSubscriber : ISubscriber
{
    public void ReceiveNotification(string videoTitle)
    {
        Console.WriteLine($"SMS Subscriber: New video '{videoTitle}' uploaded.");
    }
}