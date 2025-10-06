using System.Globalization;

namespace _2_SolucaoComInterface.Entities
{
    internal class Invoice
    {
        public double BasicPayament { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayament, double tax)
        {
            BasicPayament = basicPayament;
            Tax = tax;
        }

        public double TotalPayament
        {
            get { return BasicPayament + Tax; }
        }

        public override string ToString()
        {
            return $"Basic payment: {BasicPayament.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\nTax: {Tax.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\nTotal payment: {TotalPayament.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
