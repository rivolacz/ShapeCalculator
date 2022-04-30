using ShapeCalculator.Shapes;
using System.Windows;

namespace ShapeCalculator;
public partial class MainWindow : Window , INotifyPropertyChanged
{
    public delegate void ShapeChangedDelegate(BaseShape shape);
    public event ShapeChangedDelegate OnShapeChange;

    public event PropertyChangedEventHandler? PropertyChanged;

    public BaseShape? CurrentShape { get; private set; }
    public List<string> ParametersNames { get; private set; } = new List<string>();
    public List<Parameter> Parameters { get; private set; } = new List<Parameter>();

    public MainWindow()
    {
        InitializeComponent();
        OnShapeChange += new ShapeChangedDelegate(ChangeShape);
        ShapeSelector.OnShapeSelected = OnShapeChange;            
    }

    public void ChangeShape(BaseShape shape)
    {
        CurrentShape = shape;
        UpdateImage(shape.ShapeImage);
        ParametersNames = shape.Parameters.Select((parameter) => parameter.Name).ToList();
        ParameterChangerHolder.Parameters = shape.Parameters;
    }


    private void UpdateImage(BitmapImage image)
    {
        ShapeImageHolder.Source = image;
        if (image == null) return;
        ShapeImageHolder.Width = image.Width;
        ShapeImageHolder.Height = image.Height;
    }

    private void ButtonCalculateArea(object sender, RoutedEventArgs e)
    {
        /*Type? shapeType = CurrentShape?.GetType();
        IShape? shape = (IShape)shapeType.GetInterface(nameof(IShape));
        if(shape != null)
        {
            shape.CalculateArea();
            double result = shape.GetArea();
        }*/
    }
}
