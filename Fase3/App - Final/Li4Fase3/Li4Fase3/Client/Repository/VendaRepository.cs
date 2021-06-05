using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Li4Fase3.Client.Helpers;
using Li4Fase3.Shared.Entities;
using Li4Fase3.Shared.DTOs;

namespace Li4Fase3.Client.Repository
{
    public class VendaRepository : IVendaRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/venda";

        public VendaRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<VendasDetailsDTO>> GetVendasDetailsDTO()
        {
            return await Get<List<VendasDetailsDTO>>(url);
        }

        public async Task<List<VendasDetailsDTO>> GetVendasDTOFiltro(string venda)
        {
            return await Get<List<VendasDetailsDTO>>($"{url}/{venda}");
        }

        public async Task<T> Get<T>(string url)
        {
            var response = await httpService.Get<T>(url);
            if (!response.Sucess)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }


    }
}