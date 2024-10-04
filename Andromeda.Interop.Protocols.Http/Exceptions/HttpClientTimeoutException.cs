using System;

namespace Andromeda.Interop.Protocols.Http.Exceptions
{
    public class HttpClientTimeoutException : HttpException
    {
        public HttpClientTimeoutException()
        {
        }

        public HttpClientTimeoutException(string? message) :
            base(message)
        {
        }

        public HttpClientTimeoutException(
            string? message,
            Exception? innerException
        ) : base(message, innerException)
        {
        }
    }
}
