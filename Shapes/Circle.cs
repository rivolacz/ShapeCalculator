namespace ShapeCalculator.Shapes;
public class Circle : BaseShape, IShape
{
    public override string Name { get; } = "Kruh";

    public override string FileName => "kruh.png";

    public override ObservableCollection<Parameter> Parameters { get; set; } = new ObservableCollection<Parameter>();
    private const string RadiusName = "Poloměr";
    public Circle()
    {
        LoadImage(FileName);
        InitializeParameters();
    }

    public void CalculateArea()
    {
        Parameter parameter = Parameters.FirstOrDefault((parameter) => parameter.Name == RadiusName);
        double radius = parameter.Value;
        Area = MathF.PI * radius * radius;
    }

    protected override void InitializeParameters()
    {
        Parameters.Add(new Parameter(RadiusName, 0));
    }
}
