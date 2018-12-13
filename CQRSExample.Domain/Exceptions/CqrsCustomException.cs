using System;

namespace CQRSExample.Domain.Exceptions
{
    /// <summary>
    ///     Type of exception specified for this application
    /// </summary>
    public class CqrsCustomException : Exception
    {
        public CqrsCustomException()
        {
        }

        public CqrsCustomException(string message) : base(message)
        {
        }

        public CqrsCustomException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}