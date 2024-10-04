using System;

namespace Andromeda.Interop.Protocols.Http.Exceptions
{
    public class HttpClientException : HttpException
    {
        public HttpClientException()
        {
        }

        public HttpClientException(string? message) :
            base(message)
        {
        }

        public HttpClientException(
            string? message,
            Exception? innerException
        ) : base(message, innerException)
        {
        }
    }
}
