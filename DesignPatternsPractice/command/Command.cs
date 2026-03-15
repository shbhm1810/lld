
interface ICommand
{
    void Execute();
}

class Light
{
    public void On()
    {
        Console.WriteLine("Light is ON");
    }

    public void Off()
    {
        Console.WriteLine("Light is OFF");
    }
}

class LightOnCommand : ICommand
{
    private readonly Light _light;

    public LightOnCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.On();
    }
}

class LightOffCommand : ICommand
{
    private readonly Light _light;

    public LightOffCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.Off();
    }
}

class RemoteController
{
    private ICommand _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void ExecuteCommand()
    {
        if (_command != null)
        {
            _command.Execute();
        }
        else
        {
            Console.WriteLine("No command set.");
        }
    }
}

// ICommand light = new Light();
// ICommand lightOn = new LightOnCommand(light);
// ICommand lightOff = new LightOffCommand(light);

// RemoteController remoteController = new RemoteController();
// remoteController.SetCommand(lightOn);
// remoteController.ExecuteCommand();