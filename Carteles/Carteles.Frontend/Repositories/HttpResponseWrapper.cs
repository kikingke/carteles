using System.Net;

namespace Carteles.Frontend.Repositories
{
    public class HttpResponseWrapper<T>
    {
        public HttpResponseWrapper(T? response, bool error, HttpResponseMessage httpResponseMessage)
        {
            Response = response;
            Error = error;
            HttpResponseMessage = httpResponseMessage;
        }

        public T? Response { get; }
        public bool Error { get; }
        public HttpResponseMessage HttpResponseMessage { get; }


        public async Task<string?> GetErrorMessageAsync()
        {
            if (!Error)
            {
                return null;
            }
            var statusCode = HttpResponseMessage.StatusCode;
           /* if (statusCode == HttpStatusCode.NotFound)
            {
                return "recurso no encontrado";
            }
            if (statusCode == HttpStatusCode.BadRequest)
            {
                return await HttpResponseMessage.Content.ReadAsStringAsync();
            }
            if (statusCode == HttpStatusCode.Unauthorized)
            {
                return "Logueo necesario";
            }
            if (statusCode == HttpStatusCode.Forbidden)
            {
                return "Permisos necesarios";
            }
            return "Error inesperado";*/
            switch (statusCode)
            {
                case HttpStatusCode.NotFound:
                    return "recurso no encontrado";
                case HttpStatusCode.BadRequest:
                    return await HttpResponseMessage.Content.ReadAsStringAsync();
                case HttpStatusCode.Unauthorized:
                    return "Logueo necesario";
                case HttpStatusCode.Forbidden:
                    return "Permisos necesarios";
                default:
                    return "Error inesperado";
            }

        }
    }


}
