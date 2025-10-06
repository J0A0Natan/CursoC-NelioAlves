namespace ExercicioDeFixacao.Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double value)
        {
            Number = number;
            Date = date;
            Value = value;
            Installments = new List<Installment>();
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }

        public void RemoveInstallment(Installment installment)
        {
            Installments.Remove(installment);
        }
    }
}
