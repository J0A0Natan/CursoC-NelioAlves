namespace ExercicioFixacao.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salaray { get; set; }

        public Employee(string name, string email, double salaray)
        {
            Name = name;
            Email = email;
            Salaray = salaray;
        }
    }
}
