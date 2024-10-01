using System;

namespace Andromeda.Interop.Http.Exceptions
{
    public class HttpNoResponseException : HttpException
    {
        public HttpNoResponseException()
        {
        }

        public HttpNoResponseException(string? message) :
            base(message)
        {
        }

        public HttpNoResponseException(
            string? message,
            Exception? innerException
        ) : base(message, innerException)
        {
        }
    }
}
