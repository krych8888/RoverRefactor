namespace RoverRefactor.Rover;

public static class RoverFactory
{
    public static Rover CreateRover(int x, int y, char direction) =>
        new Rover(new Position(x, y), DirectionFactory.CreateDirection(direction));
}
