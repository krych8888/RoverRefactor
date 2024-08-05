using RoverRefactor.Commands;

namespace RoverRefactor.Rover;

public class Rover
{
    public readonly Position Position;
    public readonly IDirection Direction;

    public Rover(Position position, IDirection direction)
    {
        Position = position;
        Direction = direction;
    }

    public string RoverPositionAndDirection() => $"{Position.X}, {Position.Y}, {Direction.DirectionAsString()}";
    public Rover Apply(ICommand command) => ApplyCommand((dynamic)command);
    private Rover ApplyCommand(MoveForwardCommand c) => new Rover(Direction.MoveForward(Position), Direction);
    private Rover ApplyCommand(TurnLeftCommand c) => new Rover(Position, Direction.TurnLeft());
    private Rover ApplyCommand(TurnRightCommand c) => new Rover(Position, Direction.TurnRight());
}
