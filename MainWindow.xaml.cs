﻿using ShapeCalculator.Shapes;
using System.Windows;

namespace ShapeCalculator;
public partial class MainWindow : Window
{
    public delegate void ShapeChangedDelegate(BaseShape shape);
    public event ShapeChangedDelegate OnShapeChange;
    public BaseShape? CurrentShape { get; private set; }
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
        IShape? shape = (IShape)CurrentShape;
        if (shape != null)
        {
            shape.CalculateArea();
            double result = shape.GetArea();
            ResultLabel.Text = result.ToString();
        }
    }
}
