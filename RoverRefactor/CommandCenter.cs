using RoverRefactor.Commands;

namespace RoverRefactor;

public class CommandCenter
{
    private Rover.Rover _rover { get; set; }

    public CommandCenter(Rover.Rover rover)
    {
        _rover = rover;
    }

    public void Move(string commands)
    {
        foreach (char command in commands)
        {
            _rover = _rover.Apply(CommandFactory.CreateRoverCommand(command));
        }
    }

    public string GetPosition() => _rover.RoverPositionAndDirection();
    public void PrintPosition() => Console.WriteLine($"Rover Position: {GetPosition()}");
}
