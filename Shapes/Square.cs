using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace ShapeCalculator.Shapes
{
    public class Square : BaseShape, IShape
    {
        public double Area {get; private set;}
        public override string Name => "Čtverec";
        public double Side;

        private string fileName = "ctverec.png";
        public Square(double side)
        {
            Side = side;
            CalculateArea();
            LoadImage(fileName);
        }
        public Square() {
            LoadImage(fileName);
        }

        public void CalculateArea()
        {
            Area = Side * Side;
        }

        public double GetArea()
        {
            return Area;
        }
    }
}
