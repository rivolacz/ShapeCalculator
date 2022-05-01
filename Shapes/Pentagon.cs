namespace ShapeCalculator.Shapes;
public class Pentagon : BaseShape, IShape
{
    public override string Name => "Pětiúhelník";

    public override string FileName => "pentagon.png";

    public override ObservableCollection<Parameter> Parameters { get; set; } = new ObservableCollection<Parameter>();

    private const string BaseSideName = "délka strany";

    public Pentagon()
    {
        LoadImage(FileName);
        InitializeParameters();
    }

    public void CalculateArea()
    {
        Parameter baseSideparameter = Parameters.FirstOrDefault((parameter) => parameter.Name == BaseSideName);
        double baseSideValue = baseSideparameter.Value;
        double sqrtValue = Math.Sqrt(25 + 10 * Math.Sqrt(5));
        Area = baseSideValue * baseSideValue * sqrtValue / 4;
    }

    protected override void InitializeParameters()
    {
        Parameters.Add(new Parameter(BaseSideName, 0));
    }
}
