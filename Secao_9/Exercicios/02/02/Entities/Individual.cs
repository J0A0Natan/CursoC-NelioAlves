namespace _02.Entities
{
    internal class Individual : TaxPayer
    {
        public double Health { get; set; }

        public Individual(string name, double income, double health) : base(name, income)
        {
            Health = health;
        }

        public override double Tax()
        {
            if (Income < 20000.00)
            {
                if (Health > 0)
                    return Income * 0.15 - Health * 0.5;
                else
                    return Income * 0.15;
            }
            else
            {
                if (Health > 0)
                    return Income * 0.25 - Health * 0.5;
                else
                    return Income * 0.25;
            }
        }
    }
}
