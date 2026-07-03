namespace LevLesson;

internal class Car1
{
    private string _make;
    private string _model;

    internal string Make
    {
        get { return _make; }
        private set { _make = value; }
    }
    
    internal string Model
    {
        get { return _model; }
        private set { _model = value; }
    }
    
    public Car1(string make, string model)
    {
        Make = make;
        Model = model;
    }
}