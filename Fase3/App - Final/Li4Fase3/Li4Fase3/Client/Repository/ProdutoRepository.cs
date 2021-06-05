using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Li4Fase3.Client.Helpers;
using Li4Fase3.Shared.Entities;
using Li4Fase3.Shared.DTOs;

namespace Li4Fase3.Client.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/produto";

        public ProdutoRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Produto>> GetProduto()
        {
            return await Get<List<Produto>>(url);
        }

        public async Task<ProdutoDetailsDTO> GetProdutoDetailsDTO(int id)
        {
            return await Get<ProdutoDetailsDTO>($"{url}/{id}");
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