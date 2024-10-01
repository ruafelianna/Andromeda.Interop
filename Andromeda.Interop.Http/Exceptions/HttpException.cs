using System;

namespace Andromeda.Interop.Http.Exceptions
{
    public class HttpException : ApplicationException
    {
        public HttpException()
        {
        }

        public HttpException(string? message) :
            base(message)
        {
        }

        public HttpException(
            string? message,
            Exception? innerException
        ) : base(message, innerException)
        {
        }
    }
}
