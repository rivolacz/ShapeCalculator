using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShapeCalculator;

/// <summary>
/// Interaction logic for ParameterChanger.xaml
/// </summary>
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
