using ShapeCalculator.Shapes;

namespace ShapeCalculator;
public partial class ShapeSelector : UserControl
{
    public Delegate? OnShapeSelected;

    public List<IShape> Shapes { get; set; } = new List<IShape>();

    public ShapeSelector()
    {
        InitializeComponent();
        AddShapes();
        DataContext = this;
    }

    public void ShapeSelected(object sender, SelectionChangedEventArgs e)
    {
        var itemSelected = e.AddedItems;
        BaseShape shapeSelected = (BaseShape)itemSelected[0];
        OnShapeSelected?.DynamicInvoke(shapeSelected);
    }

    private void AddShapes()
    {
        var type = typeof(IShape);
        var types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(p => type.IsAssignableFrom(p) && !p.IsInterface);
        foreach (var IType in types)
        {
            Shapes.Add((IShape)Activator.CreateInstance(IType));
        }
    }
}
