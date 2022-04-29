using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ShapeCalculator.Shapes;

namespace ShapeCalculator;

/// <summary>
/// Interaction logic for ShapeSelector.xaml
/// </summary>
public partial class ShapeSelector : UserControl
{
    public List<IShape> Shapes { get; set; } = new List<IShape>();

    public ShapeSelector()
    {
        InitializeComponent();
        Shapes.Add(new Square());
        DataContext = this;
    }

    public void ShapeSelected(object sender, SelectionChangedEventArgs e)
    {

    }
}
