using System.Globalization;

namespace _02.Entities
{
    internal abstract class TaxPayer
    {
        public string Name { get; set; }
        public double Income { get; set; }

        protected TaxPayer(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double Tax();

        public override string ToString()
        {
            return $"{Name}: $ {Tax().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
