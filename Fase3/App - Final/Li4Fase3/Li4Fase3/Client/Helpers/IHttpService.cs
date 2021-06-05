using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Li4Fase3.Client.Helpers
{
    public interface IHttpService
    {
        Task<HttpResponseWrapper<object>> Post<T>(string url, T data);
        Task<HttpResponseWrapper<T>> Get<T>(string url);
    }
}