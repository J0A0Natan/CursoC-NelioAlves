namespace _5
{
    internal class Aluno
    {
        public string Nome;
        public double N1, N2, N3;

        public double CalculaNotaFinal()
        {
            return N1 + N2 + N3;
        }

        public bool Aprovado()
        {
            if (CalculaNotaFinal() >= 60.0)
                return true;
            else
                return false;
        }

        public double PontosRestantes()
        {
            if (!Aprovado())
                return 60.0 - CalculaNotaFinal();
            else
                return 0.0;
        }
    }
}
