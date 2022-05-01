namespace ShapeCalculator.Shapes;
public class Rectangle : BaseShape, IShape
{
    public override string Name => "Obdélník";

    public override string FileName => "obdelnik.png";

    public override ObservableCollection<Parameter> Parameters { get; set; } = new ObservableCollection<Parameter>();

    private const string BaseSide = "a";
    private const string RightSide = "b";

    public Rectangle()
    {
        LoadImage(FileName);
        InitializeParameters();
    }

    public void CalculateArea()
    {
        Parameter BaseSideparameter = Parameters.FirstOrDefault((parameter) => parameter.Name == BaseSide);
        Parameter RightSideparameter = Parameters.FirstOrDefault((parameter) => parameter.Name == RightSide);

        double BaseSideValue = BaseSideparameter.Value;
        double RightSideValue = RightSideparameter.Value;
        Area = BaseSideValue * RightSideValue;
    }

    protected override void InitializeParameters()
    {
        Parameters.Add(new Parameter(BaseSide, 0));
        Parameters.Add(new Parameter(RightSide, 0));
    }
}
