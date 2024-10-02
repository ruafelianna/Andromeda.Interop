using System;

namespace Andromeda.Interop.Http.Exceptions
{
    public class HttpRequestCanceledException : HttpException
    {
        public HttpRequestCanceledException()
        {
        }

        public HttpRequestCanceledException(string? message) :
            base(message)
        {
        }

        public HttpRequestCanceledException(
            string? message,
            Exception? innerException
        ) : base(message, innerException)
        {
        }
    }
}