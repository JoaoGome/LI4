using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Li4Fase3.Client.Helpers;
using Li4Fase3.Shared.Entities;

namespace Li4Fase3.Client.Repository
{
    public class CondicaoRepository : ICondicaoRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/condicao";

        public CondicaoRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Condicao>> GetCondicao()
        {
            var response = await httpService.Get<List<Condicao>>(url);
            if (!response.Sucess)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

    }
}