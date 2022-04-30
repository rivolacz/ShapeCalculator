namespace ShapeCalculator;
public class Parameter
{
    public string? Name { get; set; }
    public double Value { get; set; }

    public Parameter(string name, double value)
    {
        Name = name;
        Value = value;
    }
}
