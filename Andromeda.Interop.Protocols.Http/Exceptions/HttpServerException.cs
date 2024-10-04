using System;

namespace Andromeda.Interop.Protocols.Http.Exceptions
{
    public class HttpServerException : HttpException
    {
        public HttpServerException()
        {
        }

        public HttpServerException(string? message) :
            base(message)
        {
        }

        public HttpServerException(
            string? message,
            Exception? innerException
        ) : base(message, innerException)
        {
        }
    }
}
