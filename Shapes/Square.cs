using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace ShapeCalculator.Shapes;

public class Square : BaseShape, IShape
{
    private const string SideName = "Strana";
    public override string Name { get; } = "Čtverec";
    public double Side;
    public override string FileName { get; } = "ctverec.png";
    public override Dictionary<string, double> Parameteres { get; set; } = new Dictionary<string, double>();

    public Square(double side)
    {
        Side = side;
        LoadImage(FileName);
        InitializeParameters();
        CalculateArea();
    }
    public Square()
    {
        LoadImage(FileName);
        InitializeParameters();
    }

    public void CalculateArea()
    {
        if (!Parameteres.ContainsKey(SideName)) return;
        double side = Parameteres[SideName];
        Area = side * side;
    }

    public double GetArea()
    {
        return Area;
    }

    protected override void InitializeParameters()
    {
        Parameteres.Add(SideName, 0);
        Parameteres.Add("123", 0); Parameteres.Add("SideName", 0); Parameteres.Add("SideName+", 0);
    }
}
