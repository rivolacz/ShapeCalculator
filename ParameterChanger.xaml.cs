using System.Globalization;

namespace ShapeCalculator;
public partial class ParameterChanger : UserControl , INotifyPropertyChanged
{
    private ObservableCollection<Parameter> parameters = new();
    public ObservableCollection<Parameter> Parameters { 
        get {
            return parameters;
        }
        set
        {
            parameters = value;
            OnPropertyChanged(nameof(Parameters));
        }
    }

    public ParameterChanger()
    {
        InitializeComponent();
        DataContext = this;
        ParametersHolder.ItemsSource = Parameters;
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private void TextBox_NumberCheck(object sender, System.Windows.Input.TextCompositionEventArgs e)
    {
        TextBox text = (TextBox)sender;
        string currentNumberText = text.Text;
        string numberTextToAppend = e.Text;
        string numberParsingText = currentNumberText + numberTextToAppend;
        bool startedToWriteDecimalPart = e.Text == "," || e.Text == ".";
        if (startedToWriteDecimalPart)
        {
            numberParsingText = currentNumberText;
        }
        bool isNumber = double.TryParse(numberParsingText, NumberStyles.Any, CultureInfo.InvariantCulture, out _);
        if (!isNumber)
        {
            e.Handled = true;
        }
    }
}
