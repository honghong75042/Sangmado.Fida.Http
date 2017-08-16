﻿using System.Net;

namespace Sangmado.Fida.Http
{
    public interface IEncodedHttpClient
    {
        T Get<T>(string requestUri);

        void Put(string requestUri, object content);
        T Put<T>(string requestUri, object content);

        void PutEncoded(string requestUri, byte[] content);
        T PutEncoded<T>(string requestUri, byte[] content);

        void Post(string requestUri, object content);
        void Post(string url, object content, out HttpStatusCode statusCode);
        T Post<T>(string requestUri, object content);
        T Post<T>(string url, object content, out HttpStatusCode statusCode);

        void PostEncoded(string requestUri, byte[] content);
        void PostEncoded(string url, byte[] content, out HttpStatusCode statusCode);
        T PostEncoded<T>(string requestUri, byte[] content);
        T PostEncoded<T>(string url, byte[] content, out HttpStatusCode statusCode);
    }
}
