using System;
using System.Collections.Generic;
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

namespace ShapeCalculator
{
    /// <summary>
    /// Interaction logic for ParameterChanger.xaml
    /// </summary>
    public partial class ParameterChanger : UserControl
    {
        public string ParameterName { get; set; }
        public double ParameterValue { get; set; }

        public ParameterChanger()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
