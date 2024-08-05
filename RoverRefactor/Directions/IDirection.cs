

public interface IDirection 
{
    public Position MoveForward(Position position);
    public IDirection TurnLeft();
    public IDirection TurnRight();
    public string DirectionAsString();
}
