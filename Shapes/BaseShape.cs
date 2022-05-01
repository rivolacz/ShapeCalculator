namespace ShapeCalculator.Shapes;
public abstract class BaseShape
{
    public abstract string Name { get; }
    public abstract string FileName { get; }
    public double Area { get; protected set; }
    public BitmapImage ShapeImage { get; private set; } = new BitmapImage();
    public abstract ObservableCollection<Parameter> Parameters { get; set; }

    private string directoryName = "ShapeImages";
    protected void LoadImage(string fileName)
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        string path = Path.Combine(currentDirectory, directoryName, fileName);
        var uri = new Uri(path);
        try
        {
            ShapeImage = new BitmapImage(uri);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public double GetArea()
    {
        return Area;
    }

    protected abstract void InitializeParameters();
}
