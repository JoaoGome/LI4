using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace Li4Fase3.Client.Helpers 
{
    public class HttpResponseWrapper<T>
    {
        public HttpResponseWrapper(T response, bool success, HttpResponseMessage httpResponseMessage)
        {
            Sucess = success;
            Response = response;
            HttpResponseMessage = httpResponseMessage;
        }

        public bool Sucess {get; set;}
        public T Response {get; set;}
        public HttpResponseMessage HttpResponseMessage {get; set;}

        public async Task<string> GetBody()
        {
            return await HttpResponseMessage.Content.ReadAsStringAsync();
        }

    }
}

