
public static class DirectionFactory
{
    public static IDirection CreateDirection(char direction) => direction switch
    {
        'N' => new North(),
        'E' => new East(),
        'S' => new South(),
        'W' => new West(),
        _ => throw new NotSupportedException($"Direction {direction} not supported"),
    };
}
