using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Li4Fase3.Shared.Entities;
using Li4Fase3.Shared.DTOs;

namespace Li4Fase3.Client.Repository
{
    public interface IProdutoRepository
    {
        Task<List<Produto>> GetProduto();
        Task<ProdutoDetailsDTO> GetProdutoDetailsDTO(int id);
        Task<T> Get<T>(string url);
    }
}