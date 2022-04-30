namespace ShapeCalculator.Shapes;
public class Square : BaseShape, IShape
{
    private const string SideName = "Strana";
    public override string Name { get; } = "Čtverec";
    public double Side;
    public override string FileName { get; } = "ctverec.png";
    public override ObservableCollection<Parameter> Parameters { get; set; } = new ObservableCollection<Parameter>();

    public Square(double side)
    {
        Side = side;
        LoadImage(FileName);
        InitializeParameters();
        CalculateArea();
    }
    public Square()
    {
        LoadImage(FileName);
        InitializeParameters();
    }

    public void CalculateArea()
    {
        Parameter parameter = (Parameter)Parameters.Where((parameter) => parameter.Name == SideName);
        double side = parameter.Value;
        Area = side * side;
    }

    public double GetArea()
    {
        return Area;
    }

    protected override void InitializeParameters()
    {
        Parameters.Add(new Parameter(SideName,0));
        
    }
}
