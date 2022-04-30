using ShapeCalculator.Shapes;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public delegate void ShapeChangedDelegate(BaseShape shape);
        public event ShapeChangedDelegate OnShapeChange;

        public BaseShape CurrentShape { get; private set; }
        public List<string> ParametersNames { get; private set; } = new List<string>();
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
            ParametersNames = shape.Parameteres.Keys.ToList();
        }


        private void UpdateImage(BitmapImage image)
        {
            ShapeImageHolder.Source = image;
            if (image == null) return;
            ShapeImageHolder.Width = image.Width;
            ShapeImageHolder.Height = image.Height;
        }     
    }
}
