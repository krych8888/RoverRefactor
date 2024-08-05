
public class North : IDirection
{
    public Position MoveForward(Position position) => new Position(position.X, position.Y + 1);
    public IDirection TurnLeft() => new West();
    public IDirection TurnRight() => new East();
    public string DirectionAsString() => "N";
}
