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
    [Route("api/condicao")]
    public class CondicaoController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public CondicaoController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Condicao>>> Get()
        {
            return await context.Condicao.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Condicao condicao)
        {
            context.Add(condicao);
            await context.SaveChangesAsync();
            return condicao.Id;
        }

    }
}