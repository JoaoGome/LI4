using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Li4Fase3.Server;
using Li4Fase3.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Li4Fase3.Client.Controllers
{
    [ApiController]
    [Route("api/localizacao")]
    public class LocalizacaoController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public LocalizacaoController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Localizacao>>> Get()
        {
            return await context.Localizacao.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Localizacao localizacao)
        {
            context.Add(localizacao);
            await context.SaveChangesAsync();
            return localizacao.Id;
        }

    }
}