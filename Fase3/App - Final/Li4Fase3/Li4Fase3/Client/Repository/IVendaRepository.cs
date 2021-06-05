using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Li4Fase3.Shared.Entities;
using Li4Fase3.Shared.DTOs;

namespace Li4Fase3.Client.Repository
{
    public interface IVendaRepository
    {
        Task<List<VendasDetailsDTO>> GetVendasDetailsDTO();
        Task<List<VendasDetailsDTO>> GetVendasDTOFiltro(string venda);
        Task<T> Get<T>(string url);
    }
}