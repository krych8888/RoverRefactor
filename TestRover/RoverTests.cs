using FluentAssertions;
using RoverRefactor;
using RoverRefactor.Rover;

namespace TestRover;

public class RoverTests
{
    [Theory]
    [InlineData(0, 0, 'N', "0, 0, N", "")]
    [InlineData(0, 0, 'N', "0, 1, N", "M")]
    [InlineData(0, 0, 'N', "0, 0, W", "L")]
    [InlineData(0, 0, 'N', "0, 0, E", "R")]
    [InlineData(0, 0, 'N', "0, 0, S", "RR")]
    [InlineData(0, 0, 'N', "0, 0, S", "LL")]
    [InlineData(0, 0, 'S', "0, -1, S", "M")]
    [InlineData(0, 0, 'E', "1, 0, E", "M")]
    [InlineData(0, 0, 'W', "-1, 0, W", "M")]
    [InlineData(0, 0, 'N', "2, 3, N", "MMMRMML")]
    public void Move(
        int x,
        int y,
        char direction,
        string expectedPosition,
        string command)
    {
        //Arrange
        var rover = RoverFactory.CreateRover(x, y, direction);
        var commandCenter = new CommandCenter(rover);

        //Act
        if (!string.IsNullOrEmpty(command))
        {
            commandCenter.Move(command);
        }

        //Assert
        commandCenter.GetPosition().Should().Be(expectedPosition);
    }
}