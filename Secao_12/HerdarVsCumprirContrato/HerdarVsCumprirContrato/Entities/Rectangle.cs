using System.Globalization;

namespace HerdarVsCumprirContrato.Entities
{
    internal class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return $"Rectangle color: {Color}, width = {Width}, height = {Height}, area = {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
