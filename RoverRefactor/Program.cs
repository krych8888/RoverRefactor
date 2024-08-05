using RoverRefactor.Commands;
using RoverRefactor;
using RoverRefactor.Rover;

public class Program
{
    public static void Main(string[] args)
    {
        var rover = RoverFactory.CreateRover(0, 0, 'N');
        CommandCenter roverControll = new CommandCenter(rover);
        roverControll.Move("LMLMLMLMM");
        roverControll.PrintPosition();
    }
}
