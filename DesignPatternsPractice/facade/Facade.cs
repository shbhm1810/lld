class PaymentProcessor
{
    public void ProcessPayment(string paymentMethod, decimal amount)
    {
        // Simulate payment processing logic
        Console.WriteLine($"Processing {paymentMethod} payment of ${amount}");
    }
}

class ShippingService
{
    public void ShipOrder(string address)
    {
        // Simulate shipping logic
        Console.WriteLine($"Shipping order to {address}");
    }
}

class Facade
{
    private readonly PaymentProcessor _paymentProcessor;
    private readonly ShippingService _shippingService;

    public Facade()
    {
        _paymentProcessor = new PaymentProcessor();
        _shippingService = new ShippingService();
    }

    public void PlaceOrder(string paymentMethod, decimal amount, string address)
    {
        _paymentProcessor.ProcessPayment(paymentMethod, amount);
        _shippingService.ShipOrder(address);
        Console.WriteLine("Order placed successfully!");
    }
}