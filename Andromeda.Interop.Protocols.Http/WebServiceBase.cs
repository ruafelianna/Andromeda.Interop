using Andromeda.Interop.Protocols.Http.Enums;
using Andromeda.Interop.Protocols.Http.Exceptions;
using Andromeda.Interop.Protocols.Http.Extensions;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace Andromeda.Interop.Protocols.Http
{
    public abstract class WebServiceBase
    {
        public WebServiceBase(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        static WebServiceBase()
        {
            _jsonSerializerOptions = new()
            {
                ReferenceHandler = ReferenceHandler.Preserve,
            };
        }

        protected readonly HttpClient _httpClient;

        protected static readonly JsonSerializerOptions _jsonSerializerOptions;

        protected readonly struct NoResult;

        protected static HttpRequestMessage CreateGet(string path)
            => new(HttpMethod.Get, path);

        protected static HttpRequestMessage CreatePost(
            string path,
            object? dto
        ) => new(HttpMethod.Post, path)
        {
            Content = CreateDTOContent(dto),
        };

        protected static HttpRequestMessage CreatePatch(
            string path,
            object? dto
        ) => new(HttpMethod.Patch, path)
        {
            Content = CreateDTOContent(dto),
        };

        protected static HttpRequestMessage CreateDelete(
            string path,
            object? dto
        ) => new(HttpMethod.Delete, path)
        {
            Content = CreateDTOContent(dto),
        };

        protected async Task<T> GetResponseAsync<T>(
            HttpRequestMessage request,
            CancellationToken cancellationToken = default
        )
        {
            try
            {
                var response = await _httpClient
                    .SendAsync(
                        request,
                        cancellationToken
                    )
                    ?? throw new HttpNoResponseException();

                if (response.IsSuccess())
                {
                    if (typeof(T) == typeof(NoResult))
                    {
                        return default!;
                    }

                    return await response.Content.ReadAsAsync<T>(
                        cancellationToken
                    );
                }

                if (response.IsClientError())
                {
                    throw new HttpClientException();
                }

                if (response.IsServerError())
                {
                    throw new HttpServerException();
                }

                throw new HttpUnknownResponseException();
            }
            catch (TaskCanceledException ex)
                when (ex.InnerException is TimeoutException te)
            {
                throw new HttpClientTimeoutException();
            }
            catch (TaskCanceledException)
            {
                throw new HttpRequestCanceledException();
            }
        }

        private static StringContent? CreateDTOContent(object? dto)
            => new(
                JsonSerializer.Serialize(dto, _jsonSerializerOptions),
                Encoding.UTF8,
                MimeTypes.ApplicationJson.AsString()
            );
    }
}
