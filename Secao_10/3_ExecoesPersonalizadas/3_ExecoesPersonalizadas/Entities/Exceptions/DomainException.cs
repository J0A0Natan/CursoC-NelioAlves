namespace _3_ExecoesPersonalizadas.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) : base (message)
        {
        }
    }
}
