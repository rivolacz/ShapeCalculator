namespace ShapeCalculator.Shapes;
public class Triangle : BaseShape, IShape
{
    public override string Name => "Trojúhelník";

    public override string FileName => "trojuhelnik.png";

    public override ObservableCollection<Parameter> Parameters { get; set; } = new ObservableCollection<Parameter>();

    private const string BaseSideName = "délka základny";
    private const string HeightName = "výška";

    public Triangle()
    {
        LoadImage(FileName);
        InitializeParameters();
    }

    public void CalculateArea()
    {
        Parameter baseSideparameter = Parameters.FirstOrDefault((parameter) => parameter.Name == BaseSideName);
        Parameter heightParameter = Parameters.FirstOrDefault((parameter) => parameter.Name == HeightName);

        double baseSideValue = baseSideparameter.Value;
        double heightValue = heightParameter.Value;
        Area = (baseSideValue * heightValue) / 2;
    }

    protected override void InitializeParameters()
    {
        Parameters.Add(new Parameter(BaseSideName, 0));
        Parameters.Add(new Parameter(HeightName, 0));
    }
}
