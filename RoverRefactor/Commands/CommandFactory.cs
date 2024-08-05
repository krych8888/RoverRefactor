namespace RoverRefactor.Commands;

public static class CommandFactory
{
    public static ICommand CreateRoverCommand(char command)
    {
        return command switch
        {
            'L' => new TurnLeftCommand(),
            'R' => new TurnRightCommand(),
            'M' => new MoveForwardCommand(),
            _ => throw new NotSupportedException($"Command {command} not supported"),
        };
    }
}
