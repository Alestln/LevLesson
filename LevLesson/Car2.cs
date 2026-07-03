namespace LevLesson;

internal class Car2
{
    private readonly int _speed;
    
    internal string Make { get; private init; }

    internal string Model { get; private init; }

    internal Car2(string make, string model)
    {
        Make = make;
        Model = model;
        _speed = 42;
    }

    internal void Method()
    {
        _speed = 21;
        Make = "Test";
    }
}