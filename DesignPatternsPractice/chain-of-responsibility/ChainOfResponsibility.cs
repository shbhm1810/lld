abstract class Handler
{
    protected Handler? Next { get; private set; }

    public Handler SetNext(Handler handler)
    {
        Next = handler;
        return handler;
    }

    public abstract void HandleRequest(string request);
}

class ConcreteHandlerA : Handler
{
    public override void HandleRequest(string request)
    {
        if (request == "A")
        {
            Console.WriteLine("Handled by ConcreteHandlerA");
        }
        else if (Next != null)
        {
            Next.HandleRequest(request);
        }
    }
}

class ConcreteHandlerB : Handler
{
    public override void HandleRequest(string request)
    {
        if (request == "B")
        {
            Console.WriteLine("Handled by ConcreteHandlerB");
        }
        else if (Next != null)
        {
            Next.HandleRequest(request);
        }
    }
}

// var classA = new ConcreteHandlerA();
// var classB = new ConcreteHandlerB();

// classA.SetNext(classB);

// classA.HandleRequest("A");
// classA.HandleRequest("B");
// classA.HandleRequest("C");