public class East : IDirection
{
    public Position MoveForward(Position position) => new Position(position.X + 1, position.Y);
    public IDirection TurnLeft() => new North();
    public IDirection TurnRight() => new South();
    public string DirectionAsString() => "E";
}
