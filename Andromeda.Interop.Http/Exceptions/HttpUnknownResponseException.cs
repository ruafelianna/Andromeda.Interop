using System;

namespace Andromeda.Interop.Http.Exceptions
{
    public class HttpUnknownResponseException : HttpException
    {
        public HttpUnknownResponseException()
        {
        }

        public HttpUnknownResponseException(string? message) :
            base(message)
        {
        }

        public HttpUnknownResponseException(
            string? message,
            Exception? innerException
        ) : base(message, innerException)
        {
        }
    }
}