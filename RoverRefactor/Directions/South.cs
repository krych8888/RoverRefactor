public class South : IDirection
{
    public Position MoveForward(Position position) => new Position(position.X, position.Y - 1);
    public IDirection TurnLeft() => new East();
    public IDirection TurnRight() => new West();
    public string DirectionAsString() => "S";
}
