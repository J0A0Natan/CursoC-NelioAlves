using HerdarVsCumprirContrato.Enums;

namespace HerdarVsCumprirContrato.Entities
{
    internal abstract class AbstractShape : IShape
    {
        public Color Color{ get; set; }

        public abstract double Area();
    }
}
