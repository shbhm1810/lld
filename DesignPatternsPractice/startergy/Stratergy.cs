interface IPaymentStrategy
{
    void Pay(decimal amount);
}

class Upi : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paying {amount} using UPI.");
    }
}

class CreditCard : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paying {amount} using Credit Card.");
    }
}

class PaymentProcessorStrategy
{
    private IPaymentStrategy _paymentStrategy;

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void ProcessPayment(decimal amount)
    {
        if (_paymentStrategy == null)
        {
            Console.WriteLine("No payment strategy set.");
            return;
        }
        _paymentStrategy.Pay(amount);
    }
}
