using _6_MetodosAbstratos.Entities.Enums;

namespace _6_MetodosAbstratos.Entities
{
    internal class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        
        public Rectangle(double height, double width, Color color) : base(color)
        {
            Height = height;
            Width = width;
        }

        public override double Area()
        {
            return Height * Width;
        }
    }
}
