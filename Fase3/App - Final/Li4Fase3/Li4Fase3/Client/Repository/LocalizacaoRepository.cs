using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Li4Fase3.Client.Helpers;
using Li4Fase3.Shared.Entities;

namespace Li4Fase3.Client.Repository
{
    public class LocalizacaoRepository : ILocalizacaoRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/localizacao";

        public LocalizacaoRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Localizacao>> GetLocalizacao()
        {
            var response = await httpService.Get<List<Localizacao>>(url);
            if (!response.Sucess)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

    }
}