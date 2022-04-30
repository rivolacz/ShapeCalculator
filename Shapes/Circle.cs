using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.Shapes
{
    public class Circle : BaseShape, IShape
    {
        public override string Name { get; } = "Kruh";

        public override string FileName => "kruh.png";

        public override Dictionary<string, double> Parameteres { get; set; } = new Dictionary<string, double>();
        private const string RadiusName = "Poloměr";
        public Circle()
        {
            LoadImage(FileName);
            InitializeParameters();
        }

        public void CalculateArea()
        {
            if (!Parameteres.ContainsKey(RadiusName)) return;
            double radius = Parameteres[RadiusName];
            Area = MathF.PI * radius * radius;
        }

        public double GetArea()
        {
            return Area;
        }

        protected override void InitializeParameters()
        {
            Parameteres.Add(RadiusName, 0);
        }
    }
}
