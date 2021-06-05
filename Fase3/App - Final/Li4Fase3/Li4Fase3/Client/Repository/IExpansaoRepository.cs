using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Li4Fase3.Shared.Entities;

namespace Li4Fase3.Client.Repository
{
    public interface IExpansaoRepository
    {
        Task<List<Expansao>> GetExpansao();
    }
}