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
        var uri = GetUriToImages(fileName);
        try
        {
            ShapeImage = new BitmapImage(uri);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private Uri GetUriToImages(string fileName)
    {
        //ShapeCalculator\bin\Debug\net6.0-windows  3x get parent
        string currentDirectory = Directory.GetCurrentDirectory();
        currentDirectory = Directory.GetParent(currentDirectory).FullName;
        currentDirectory = Directory.GetParent(currentDirectory).FullName;
        currentDirectory = Directory.GetParent(currentDirectory).FullName;
        string path = Path.Combine(currentDirectory, directoryName, fileName);
        Uri uri = new (path);
        return uri;
    }

    public double GetArea()
    {
        return Area;
    }

    protected abstract void InitializeParameters();
}
