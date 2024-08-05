public class West : IDirection
{
    public Position MoveForward(Position position) => new Position(position.X - 1, position.Y);
    public IDirection TurnLeft() => new South();
    public IDirection TurnRight() => new North();
    public string DirectionAsString() => "W";
}
