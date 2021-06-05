using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Li4Fase3.Client.Helpers;
using Li4Fase3.Shared.Entities;

namespace Li4Fase3.Client.Repository
{
    public class ExpansaoRepository: IExpansaoRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/expansao";

        public ExpansaoRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Expansao>> GetExpansao()
        {
            var response = await httpService.Get<List<Expansao>>(url);
            if (!response.Sucess)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

    }
}