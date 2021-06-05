using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Li4Fase3.Client.Helpers;
using Li4Fase3.Shared.Entities;

namespace Li4Fase3.Client.Repository
{
    public class LinguagemRepository : ILinguagemRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/linguagem";

        public LinguagemRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Linguagem>> GetLinguagem()
        {
            var response = await httpService.Get<List<Linguagem>>(url);
            if (!response.Sucess)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

    }
}