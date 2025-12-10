using CryptoExchange.Net.Converters.SystemTextJson.MessageHandlers;
using CryptoExchange.Net.Objects;
using CryptoExchange.Net.Objects.Errors;
using System.IO;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace CoinGecko.Net.Clients.MessageHandlers
{
    internal class CoinGeckoRestMessageHandler : JsonRestMessageHandler
    {
        private readonly ErrorMapping _errorMapping;

        public override JsonSerializerOptions Options { get; } = SerializerOptions.WithConverters(CoinGeckoApi.SerializationContext);

        public CoinGeckoRestMessageHandler(ErrorMapping errorMapping)
        {
            _errorMapping = errorMapping;
        }

        public override async ValueTask<Error> ParseErrorResponse(
            int httpStatusCode,
            HttpResponseHeaders responseHeaders,
            Stream responseStream)
        {
            if (httpStatusCode == 401 || httpStatusCode == 403)
                return new ServerError(new ErrorInfo(ErrorType.Unauthorized, "Unauthorized"));

            var (result, doc) = await GetJsonDocument(responseStream).ConfigureAwait(false);
            if (result != null)
                return new ServerError(ErrorInfo.Unknown);

            int? code = doc!.RootElement.TryGetProperty("error_code", out var codeProp) ? codeProp.GetInt32() : null;
            var msg = doc.RootElement.TryGetProperty("status", out var statusProp) ? statusProp.TryGetProperty("error_message", out var msgProp) ? msgProp.GetString() : null : null;

            if (code != null && msg != null)
                return new ServerError(code.Value, _errorMapping.GetErrorInfo(code.ToString()!, msg));

            code = statusProp.TryGetProperty("error_code", out var statusCodeProp) ? statusCodeProp.GetInt32() : null;
            if (code != null && msg != null)
                return new ServerError(code.Value, _errorMapping.GetErrorInfo(code!.ToString()!, msg));

            return new ServerError(ErrorInfo.Unknown);

        }
    }
}
