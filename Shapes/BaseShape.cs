using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ShapeCalculator.Shapes
{
    public abstract class BaseShape
    {
        public abstract string Name { get; }
        public BitmapImage ShapeImage { get; private set; } = new BitmapImage();
        private string directoryName = "ShapeImages";

        protected BitmapImage LoadImage(string fileName)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string path = Path.Combine(currentDirectory, directoryName, fileName);
            var uri = new Uri(path);
            BitmapImage shapeImage = new BitmapImage();
            try
            {
                shapeImage = new BitmapImage(uri);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return shapeImage;
        }
    }
}
