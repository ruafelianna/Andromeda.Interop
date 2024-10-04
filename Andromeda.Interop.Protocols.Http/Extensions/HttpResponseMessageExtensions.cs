using Andromeda.Interop.Protocols.Http.Enums;
using System.Net.Http;

namespace Andromeda.Interop.Protocols.Http.Extensions
{
    public static class HttpResponseMessageExtensions
    {
        public static HttpStatusCodeType GetStatusType(
            this HttpResponseMessage response
        ) => (int)response.StatusCode switch
        {
            >= 100 and < 200 => HttpStatusCodeType.Informational,
            >= 200 and < 300 => HttpStatusCodeType.Success,
            >= 300 and < 400 => HttpStatusCodeType.Redirection,
            >= 400 and < 500 => HttpStatusCodeType.ClientError,
            >= 500 and < 600 => HttpStatusCodeType.ServerError,
            _ => HttpStatusCodeType.Unknown,
        };

        public static bool IsInformational(
            this HttpResponseMessage response
        ) => response.GetStatusType() == HttpStatusCodeType.Informational;

        public static bool IsSuccess(
            this HttpResponseMessage response
        ) => response.GetStatusType() == HttpStatusCodeType.Success;

        public static bool IsRedirection(
            this HttpResponseMessage response
        ) => response.GetStatusType() == HttpStatusCodeType.Redirection;

        public static bool IsClientError(
            this HttpResponseMessage response
        ) => response.GetStatusType() == HttpStatusCodeType.ClientError;

        public static bool IsServerError(
            this HttpResponseMessage response
        ) => response.GetStatusType() == HttpStatusCodeType.ServerError;
    }
}
