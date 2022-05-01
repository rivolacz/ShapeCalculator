namespace ShapeCalculator.Shapes;
public class Trapezoid : BaseShape, IShape
{
    public override string Name => "Lichoběžník";
    public override string FileName => "lichobeznik.png";

    public override ObservableCollection<Parameter> Parameters { get; set; } = new ObservableCollection<Parameter>();

    private const string BaseSide = "a";
    private const string TopSide = "c";
    private const string Height = "v";

    public Trapezoid()
    {
        LoadImage(FileName);
        InitializeParameters();
    }

    public void CalculateArea()
    {
        Parameter BaseSideparameter = Parameters.FirstOrDefault((parameter) => parameter.Name == BaseSide);
        Parameter TopSideparameter = Parameters.FirstOrDefault((parameter) => parameter.Name == TopSide);
        Parameter Heightparameter = Parameters.FirstOrDefault((parameter) => parameter.Name == Height);

        double BaseSideValue = BaseSideparameter.Value;
        double TopSideValue = TopSideparameter.Value;
        double HeightValue = Heightparameter.Value;
        Area = (BaseSideValue + TopSideValue) * HeightValue / 2;
    }

    protected override void InitializeParameters()
    {
        Parameters.Add(new Parameter(BaseSide, 0));
        Parameters.Add(new Parameter(TopSide, 0));
        Parameters.Add(new Parameter(Height, 0));
    }
}
