namespace _02.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberEmployees { get; set; }

        public Company(string name, double income, int numberEmployees) : base(name, income)
        {
            NumberEmployees = numberEmployees;
        }

        public override double Tax()
        {
            if (NumberEmployees > 10)
                return Income * 0.14;
            else
                return Income * 0.16;
        }
    }
}
