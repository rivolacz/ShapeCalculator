namespace ShapeCalculator;
public partial class ParameterChanger : UserControl , INotifyPropertyChanged
{
    private List<string> parametersNames = new();
    public List<string> ParametersNames { 
        get {
            return parametersNames;
        }
        set
        {
            parametersNames = value;
            OnPropertyChanged(nameof(ParametersNames));
        }
    }

    public ParameterChanger()
    {
        InitializeComponent();
        DataContext = this;
        ParametersHolder.ItemsSource = ParametersNames;
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
