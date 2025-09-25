namespace _6_MembrosEstaticos
{
    internal class ConversorDeMoeda
    {
        public static double iof = 6.0;

        public static double DolarParaReal(double quantia, double cotacao)
        {
            double tot = quantia * cotacao;
            return tot + (tot * iof / 100.0);
        }
    }
}
